﻿using System.Windows.Forms;

namespace ScriptEditor
{
	//@todo イメージの回転指定
	//Exe側でも回転の状態と角速度の計算と、アクション終了時などにリセット


	//#################################################################################
	//##
	//##	メインフォーム
	//##
	//#################################################################################
	public partial class FormMain : Form
	{
		//==================================================================================
		//	メンバ変数
		//==================================================================================
		private Chara chara = new Chara ();		//編集対象キャラクタ
		private Ctrl_Settings stgs = new Ctrl_Settings ();	//設定ファイル

		//==================================================================================
		//	コンストラクタ
		//==================================================================================
		public FormMain ()
		{
			//フォーム開始位置をマウス位置にする
			FormUtility.InitPosition ( this );

			//コンポーネントの初期化
			InitializeComponent ();

			//環境初期化
			LoadEnvironment ();

			//開始設定
			Init ();

			//キャラ初期化環境の選択
			EstablishChara ();

			//表示
			Disp ();
		}

		//==================================================================================
		//	終了時
		//==================================================================================
		private void FormMain_FormClosing ( object sender, FormClosingEventArgs e )
		{
			//メインフォームを閉じるため、
			//モーダルフォームで開いた子フォームの関連を切る
			CloseSubForms ();
		}

		//==================================================================================
		//	初回表示時に強制再描画
		//==================================================================================
		private void FormMain_Shown ( object sender, System.EventArgs e )
		{
			//ctrl_SqcList_Act.Refresh ();
		}

	}
}
