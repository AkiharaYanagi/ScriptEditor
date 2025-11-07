namespace ScriptEditor
{
	partial class FormMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.フォルダToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.上書保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.特殊保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存イメージ以外ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存イメージ込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.別名保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.基準保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.特殊読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.読込イメージ以外ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.読込scpimgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.テキストから読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.バイナリから読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新規NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.プレデータToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.名前チェックToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabAction = new System.Windows.Forms.TabPage();
			this.tabScriptA = new System.Windows.Forms.TabPage();
			this.tabEffect = new System.Windows.Forms.TabPage();
			this.tabScriptE = new System.Windows.Forms.TabPage();
			this.tabCommand = new System.Windows.Forms.TabPage();
			this.tabBranch = new System.Windows.Forms.TabPage();
			this.tabRoute = new System.Windows.Forms.TabPage();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.scp置換読込ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォルダToolStripMenuItem,
            this.上書保存ToolStripMenuItem,
            this.特殊保存ToolStripMenuItem,
            this.読込ToolStripMenuItem,
            this.特殊読込ToolStripMenuItem,
            this.新規NToolStripMenuItem,
            this.プレデータToolStripMenuItem,
            this.名前チェックToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(972, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// フォルダToolStripMenuItem
			// 
			this.フォルダToolStripMenuItem.Name = "フォルダToolStripMenuItem";
			this.フォルダToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.フォルダToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.フォルダToolStripMenuItem.Text = "フォルダ(&F)";
			this.フォルダToolStripMenuItem.Click += new System.EventHandler(this.フォルダToolStripMenuItem_Click);
			// 
			// 上書保存ToolStripMenuItem
			// 
			this.上書保存ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.上書保存ToolStripMenuItem.Name = "上書保存ToolStripMenuItem";
			this.上書保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.上書保存ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.上書保存ToolStripMenuItem.Text = "上書保存(&S)";
			this.上書保存ToolStripMenuItem.Click += new System.EventHandler(this.上書保存ToolStripMenuItem_Click);
			// 
			// 特殊保存ToolStripMenuItem
			// 
			this.特殊保存ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.特殊保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存イメージ以外ToolStripMenuItem,
            this.保存イメージ込みToolStripMenuItem,
            this.別名保存ToolStripMenuItem,
            this.基準保存ToolStripMenuItem});
			this.特殊保存ToolStripMenuItem.Name = "特殊保存ToolStripMenuItem";
			this.特殊保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.特殊保存ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.特殊保存ToolStripMenuItem.Text = "特殊保存(&A)";
			// 
			// 保存イメージ以外ToolStripMenuItem
			// 
			this.保存イメージ以外ToolStripMenuItem.Name = "保存イメージ以外ToolStripMenuItem";
			this.保存イメージ以外ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.保存イメージ以外ToolStripMenuItem.Text = "保存(イメージ以外)";
			this.保存イメージ以外ToolStripMenuItem.Click += new System.EventHandler(this.保存イメージ以外ToolStripMenuItem_Click);
			// 
			// 保存イメージ込みToolStripMenuItem
			// 
			this.保存イメージ込みToolStripMenuItem.Name = "保存イメージ込みToolStripMenuItem";
			this.保存イメージ込みToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.保存イメージ込みToolStripMenuItem.Text = "保存(イメージ込み)";
			this.保存イメージ込みToolStripMenuItem.Click += new System.EventHandler(this.保存イメージ込みToolStripMenuItem_Click);
			// 
			// 別名保存ToolStripMenuItem
			// 
			this.別名保存ToolStripMenuItem.Name = "別名保存ToolStripMenuItem";
			this.別名保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.別名保存ToolStripMenuItem.Text = "別名保存";
			this.別名保存ToolStripMenuItem.Click += new System.EventHandler(this.別名保存ToolStripMenuItem_Click);
			// 
			// 基準保存ToolStripMenuItem
			// 
			this.基準保存ToolStripMenuItem.Name = "基準保存ToolStripMenuItem";
			this.基準保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.基準保存ToolStripMenuItem.Text = "基準保存";
			this.基準保存ToolStripMenuItem.Click += new System.EventHandler(this.基準保存TToolStripMenuItem_Click);
			// 
			// 読込ToolStripMenuItem
			// 
			this.読込ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.読込ToolStripMenuItem.Name = "読込ToolStripMenuItem";
			this.読込ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.読込ToolStripMenuItem.Text = "読込(&O)";
			this.読込ToolStripMenuItem.Click += new System.EventHandler(this.読込ToolStripMenuItem_Click);
			// 
			// 特殊読込ToolStripMenuItem
			// 
			this.特殊読込ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.特殊読込ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.読込イメージ以外ToolStripMenuItem,
            this.読込scpimgToolStripMenuItem,
            this.テキストから読込ToolStripMenuItem,
            this.バイナリから読込ToolStripMenuItem,
            this.scp置換読込ToolStripMenuItem});
			this.特殊読込ToolStripMenuItem.Name = "特殊読込ToolStripMenuItem";
			this.特殊読込ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.特殊読込ToolStripMenuItem.Text = "特殊読込(&T)";
			// 
			// 読込イメージ以外ToolStripMenuItem
			// 
			this.読込イメージ以外ToolStripMenuItem.Name = "読込イメージ以外ToolStripMenuItem";
			this.読込イメージ以外ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.読込イメージ以外ToolStripMenuItem.Text = "読込(scp+dir)";
			this.読込イメージ以外ToolStripMenuItem.Click += new System.EventHandler(this.読込イメージ以外ToolStripMenuItem_Click);
			// 
			// 読込scpimgToolStripMenuItem
			// 
			this.読込scpimgToolStripMenuItem.Name = "読込scpimgToolStripMenuItem";
			this.読込scpimgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.読込scpimgToolStripMenuItem.Text = "読込(scp+img)";
			this.読込scpimgToolStripMenuItem.Click += new System.EventHandler(this.読込scpimgToolStripMenuItem_Click);
			// 
			// テキストから読込ToolStripMenuItem
			// 
			this.テキストから読込ToolStripMenuItem.Name = "テキストから読込ToolStripMenuItem";
			this.テキストから読込ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.テキストから読込ToolStripMenuItem.Text = "テキストから読込";
			this.テキストから読込ToolStripMenuItem.Click += new System.EventHandler(this.テキストから読込ToolStripMenuItem_Click);
			// 
			// バイナリから読込ToolStripMenuItem
			// 
			this.バイナリから読込ToolStripMenuItem.Name = "バイナリから読込ToolStripMenuItem";
			this.バイナリから読込ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.バイナリから読込ToolStripMenuItem.Text = "バイナリから読込";
			this.バイナリから読込ToolStripMenuItem.Click += new System.EventHandler(this.バイナリから読込BToolStripMenuItem_Click);
			// 
			// 新規NToolStripMenuItem
			// 
			this.新規NToolStripMenuItem.Name = "新規NToolStripMenuItem";
			this.新規NToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.新規NToolStripMenuItem.Text = "新規(&N)";
			this.新規NToolStripMenuItem.Click += new System.EventHandler(this.新規NToolStripMenuItem_Click);
			// 
			// プレデータToolStripMenuItem
			// 
			this.プレデータToolStripMenuItem.Name = "プレデータToolStripMenuItem";
			this.プレデータToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.プレデータToolStripMenuItem.Text = "プレデータ";
			this.プレデータToolStripMenuItem.Click += new System.EventHandler(this.プレデータToolStripMenuItem_Click);
			// 
			// 名前チェックToolStripMenuItem
			// 
			this.名前チェックToolStripMenuItem.Name = "名前チェックToolStripMenuItem";
			this.名前チェックToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.名前チェックToolStripMenuItem.Text = "名前チェック";
			this.名前チェックToolStripMenuItem.Click += new System.EventHandler(this.名前チェックToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 762);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(972, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 17);
			this.toolStripStatusLabel1.Text = "test";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabAction);
			this.tabControl1.Controls.Add(this.tabScriptA);
			this.tabControl1.Controls.Add(this.tabEffect);
			this.tabControl1.Controls.Add(this.tabScriptE);
			this.tabControl1.Controls.Add(this.tabCommand);
			this.tabControl1.Controls.Add(this.tabBranch);
			this.tabControl1.Controls.Add(this.tabRoute);
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(972, 735);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
			// 
			// tabAction
			// 
			this.tabAction.Location = new System.Drawing.Point(4, 22);
			this.tabAction.Name = "tabAction";
			this.tabAction.Size = new System.Drawing.Size(964, 709);
			this.tabAction.TabIndex = 6;
			this.tabAction.Text = "アクション ->";
			this.tabAction.UseVisualStyleBackColor = true;
			// 
			// tabScriptA
			// 
			this.tabScriptA.AutoScroll = true;
			this.tabScriptA.Location = new System.Drawing.Point(4, 22);
			this.tabScriptA.Name = "tabScriptA";
			this.tabScriptA.Padding = new System.Windows.Forms.Padding(3);
			this.tabScriptA.Size = new System.Drawing.Size(964, 709);
			this.tabScriptA.TabIndex = 0;
			this.tabScriptA.Text = "スクリプト(A)";
			this.tabScriptA.UseVisualStyleBackColor = true;
			// 
			// tabEffect
			// 
			this.tabEffect.Location = new System.Drawing.Point(4, 22);
			this.tabEffect.Name = "tabEffect";
			this.tabEffect.Size = new System.Drawing.Size(964, 709);
			this.tabEffect.TabIndex = 7;
			this.tabEffect.Text = "エフェクト ->";
			this.tabEffect.UseVisualStyleBackColor = true;
			// 
			// tabScriptE
			// 
			this.tabScriptE.Location = new System.Drawing.Point(4, 22);
			this.tabScriptE.Name = "tabScriptE";
			this.tabScriptE.Padding = new System.Windows.Forms.Padding(3);
			this.tabScriptE.Size = new System.Drawing.Size(964, 709);
			this.tabScriptE.TabIndex = 1;
			this.tabScriptE.Text = "スクリプト(E)";
			this.tabScriptE.UseVisualStyleBackColor = true;
			// 
			// tabCommand
			// 
			this.tabCommand.Location = new System.Drawing.Point(4, 22);
			this.tabCommand.Name = "tabCommand";
			this.tabCommand.Size = new System.Drawing.Size(964, 709);
			this.tabCommand.TabIndex = 2;
			this.tabCommand.Text = "コマンド";
			this.tabCommand.UseVisualStyleBackColor = true;
			// 
			// tabBranch
			// 
			this.tabBranch.Location = new System.Drawing.Point(4, 22);
			this.tabBranch.Name = "tabBranch";
			this.tabBranch.Size = new System.Drawing.Size(964, 709);
			this.tabBranch.TabIndex = 4;
			this.tabBranch.Text = "ブランチ";
			this.tabBranch.UseVisualStyleBackColor = true;
			// 
			// tabRoute
			// 
			this.tabRoute.Location = new System.Drawing.Point(4, 22);
			this.tabRoute.Name = "tabRoute";
			this.tabRoute.Size = new System.Drawing.Size(964, 709);
			this.tabRoute.TabIndex = 5;
			this.tabRoute.Text = "ルート";
			this.tabRoute.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// scp置換読込ToolStripMenuItem
			// 
			this.scp置換読込ToolStripMenuItem.Name = "scp置換読込ToolStripMenuItem";
			this.scp置換読込ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.scp置換読込ToolStripMenuItem.Text = "scp置換読込";
			this.scp置換読込ToolStripMenuItem.Click += new System.EventHandler(this.scp置換読込ToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 784);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "ScriptEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem 上書保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 読込ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem フォルダToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabScriptA;
		private System.Windows.Forms.TabPage tabCommand;
		private System.Windows.Forms.ToolStripMenuItem 特殊保存ToolStripMenuItem;
		private System.Windows.Forms.TabPage tabScriptE;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem 特殊読込ToolStripMenuItem;
		private System.Windows.Forms.TabPage tabBranch;
		private System.Windows.Forms.TabPage tabRoute;
		private System.Windows.Forms.TabPage tabAction;
		private System.Windows.Forms.TabPage tabEffect;
		private System.Windows.Forms.ToolStripMenuItem 新規NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem プレデータToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 名前チェックToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 読込イメージ以外ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem テキストから読込ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem バイナリから読込ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存イメージ以外ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存イメージ込みToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 別名保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 基準保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 読込scpimgToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scp置換読込ToolStripMenuItem;
	}
}

