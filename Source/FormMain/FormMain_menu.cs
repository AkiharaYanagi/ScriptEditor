﻿using System;
using System.IO;
using System.Windows.Forms;


namespace ScriptEditor
{
	public partial class FormMain : Form
	{
		//==================================================================================
		//	メインメニュー
		//==================================================================================

		//コマンドラインから現在位置でエクスプローラを開く
		private void フォルダToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			FormUtility.OpenCurrentDir ();
		}

		private void 上書保存ToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			string filepath = stgs.LastFilepath;

			//強制描画
			SetFormText ( "上書保存 - 開始 " + filepath );
			STS_TXT.Trace ( "上書保存 - 開始" );
			this.Refresh ();


			_SaveChara ( stgs.LastFilepath );
			SavePath_Stg ( stgs.LastFilepath );		//パスの保存

			//タイトルバー編集中ファイル名更新(非保存表示を消去)
			//SetFormText ( "◆ 完了 ◆ 上書保存 - " + filepath );
			this.Text = "◆ 完了 ◆ 上書保存 - " + filepath;
			STS_TXT.Trace ( "上書保存 - ◆ 完了 ◆" );
		}

		private void 保存イメージ以外ToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			//基本拡張子
			saveFileDialog1.DefaultExt = "scp";

			//初期ファイル名
			string fn_wex = Path.GetFileNameWithoutExtension ( stgs.LastFilepath );
			saveFileDialog1.FileName = fn_wex + ".scp";
			saveFileDialog1.OverwritePrompt = true;
			saveFileDialog1.Title = "保存 イメージ以外 scp";

			STS_TXT.Trace ( "開始：保存 イメージ以外 scp" );

			//ダイアログ開始
			if ( saveFileDialog1.ShowDialog () == DialogResult.OK )
			{
				SaveCharaImg saveCharaImg = new SaveCharaImg();
				saveCharaImg.DoWithoutImg ( saveFileDialog1.FileName, chara );
				STS_TXT.Trace ( "◆◆完了：保存 イメージ以外" );
			}

		}

		private void 保存イメージ込みToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			STS_TXT.Trace ( "開始：保存 イメージ込み scp + img" );
			SaveCharaImg saveCharaImg = new SaveCharaImg();
			saveCharaImg.DoIncludeImg ( stgs.LastFilepath, chara );
			STS_TXT.Trace ( "◆◆完了：保存 イメージ込み" );
		}

		private void 別名保存ToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			//基本拡張子
			saveFileDialog1.DefaultExt = "dat";

			//初期ファイル名
			saveFileDialog1.FileName = stgs.LastFilepath;
			saveFileDialog1.OverwritePrompt = true;
			saveFileDialog1.Title = "別名保存";

			STS_TXT.Trace ( "開始：別名保存" );
			//ダイアログ開始
			if ( saveFileDialog1.ShowDialog () == DialogResult.OK )
			{
				_SaveChara ( saveFileDialog1.FileName );

				SavePath_Stg ( saveFileDialog1.FileName );		//パスの保存
			}
			STS_TXT.Trace ( "◆◆完了：別名保存" );
		}

		private void 基準保存TToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			SaveChara saveChara = new SaveChara ();
			saveChara.Do ( "testChara.dat", chara );
			STS_TXT.Trace ( "基準保存" );
		}

		private void 読込ToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			//ダイアログ中の初期ファイル名
			openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "読込 ( *.dat )";
			openFileDialog1.DefaultExt = "dat";
			openFileDialog1.Filter = "キャラデータファイル(*.dat)|*.dat";

			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				_LoadChara ( openFileDialog1.FileName );
				SavePath_Stg ( openFileDialog1.FileName );		//パスの保存
			}
		}

		//読込 ( scp + dir )
		private void 読込イメージ以外ToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			//ダイアログ中の初期ファイル名
			openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "読込 ( scp + dir )";
			openFileDialog1.Filter = "スクリプトファイル(*.scp)|*.scp";

			STS_TXT.Trace ( "開始：読込 scp + dir" );
			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				LoadCharaImg loadCharaImg = new LoadCharaImg ();
				loadCharaImg.Do_dir ( openFileDialog1.FileName, chara );
				LoadCharaData ();
				SavePath_Stg ( openFileDialog1.FileName );		//パスの保存
			}
			STS_TXT.Trace ( "◆◆完了：読込 scp + dir" );
		}

		//読込 ( scp + img )
		private void 読込scpimgToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			//ダイアログ中の初期ファイル名
			openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "読込 ( scp + img )";
			openFileDialog1.Filter = "スクリプトファイル(*.scp)|*.scp";

			STS_TXT.Trace ( "開始：読込 scp + img" );
			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				LoadCharaImg loadCharaImg = new LoadCharaImg ();
				loadCharaImg.Do_img ( openFileDialog1.FileName, chara );
				LoadCharaData ();
				SavePath_Stg ( openFileDialog1.FileName );		//パスの保存
			}
			STS_TXT.Trace ( "◆◆完了：読込 scp + img" );
		}


		private void テキストから読込ToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			//ダイアログ中の初期ファイル名
			openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "テキストから読込 ( *.txt )";
			openFileDialog1.Filter = "キャラデータファイル(*.txt)|*.txt";

			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				LoadTextChara loadChara = new LoadTextChara ( openFileDialog1.FileName, chara );
				LoadCharaData ();
				SavePath_Stg ( openFileDialog1.FileName );		//パスの保存
			}
		}

		private void バイナリから読込BToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			//ダイアログ中の初期ファイル名
			openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "バイナリから読込";
			openFileDialog1.Filter = "キャラデータファイル(*.dat)|*.dat";

			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				LoadCharaBin loadCharaBin = new LoadCharaBin ();
				loadCharaBin.Do ( openFileDialog1.FileName, chara );
				LoadCharaData ();
				SavePath_Stg ( openFileDialog1.FileName );		//パスの保存
			}
		}

		private void 新規NToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
		}

		private void プレデータToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			OpenFolder_CodePack opF = new OpenFolder_CodePack ();
			opF.SetDefaultFilename ( stgs.LastDirectory );
			if( opF.OpenFolder () )
			{
				string path = opF.GetPath ();
				stgs.Dir_ImageListAct = path + "\\Image";
				stgs.Dir_ImageListEf = path + "\\EfImage";
				stgs.File_ActionList = path + "\\PreData\\ActionList.txt";
				stgs.File_EffectList = path + "\\PreData\\EffectList.txt";
				stgs.File_CommandList = path + "\\PreData\\CommandList.txt";
				stgs.File_BranchList = path + "\\PreData\\BranchList.txt";
				stgs.File_RouteList = path + "\\PreData\\RouteList.txt";
				XML_IO.Save ( stgs );
			}
		}

		private void 名前チェックToolStripMenuItem_Click ( object sender, System.EventArgs e )
		{
			TestChara testChara = new TestChara ();
			testChara.SOUND_DIR = Directory.GetCurrentDirectory ();

			try { testChara._TestNameAssign ( chara ); }
			catch ( Exception excp )
			{
				STS_TXT.Trace_Err ( "Name Refference Error. " + excp.Message );
				//エラー表示をして続行
				return;
			}
			STS_TXT.Trace ( "Name Check OK." );
		}

		//パスの保存
		private void SavePath_Stg ( string path )
		{
			//パスの保存
			stgs.LastFilepath = path;
			stgs.LastDirectory = Path.GetDirectoryName ( path );
			XML_IO.Save ( stgs );
			SetFormText ( stgs.LastFilepath );
		}
	}


}

