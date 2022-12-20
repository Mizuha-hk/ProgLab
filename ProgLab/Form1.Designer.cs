namespace ProgLab
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FMNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.FMOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FMAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FMClose = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vewVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.UndoButton = new System.Windows.Forms.ToolStripSplitButton();
            this.RedoButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.NewProjectButton = new System.Windows.Forms.ToolStripSplitButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExecutionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpriteList = new System.Windows.Forms.ListView();
            this.DebugPannel = new System.Windows.Forms.Panel();
            this.ControlPannel = new System.Windows.Forms.Panel();
            this.Editer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FileViewer = new System.Windows.Forms.TreeView();
            this.BottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.LoadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.PicturesURL = new System.Windows.Forms.ToolStripTextBox();
            this.testObject = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            this.TopToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ControlPannel.SuspendLayout();
            this.Editer.SuspendLayout();
            this.BottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.editEToolStripMenuItem,
            this.vewVToolStripMenuItem,
            this.toolsTToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1582, 28);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FMNewProject,
            this.FMOpen,
            this.toolStripSeparator1,
            this.FMAdd,
            this.toolStripSeparator2,
            this.FMClose});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(63, 24);
            this.FileMenu.Text = "File(F)";
            // 
            // FMNewProject
            // 
            this.FMNewProject.Name = "FMNewProject";
            this.FMNewProject.Size = new System.Drawing.Size(193, 26);
            this.FMNewProject.Text = "New Project(N)";
            // 
            // FMOpen
            // 
            this.FMOpen.Name = "FMOpen";
            this.FMOpen.Size = new System.Drawing.Size(193, 26);
            this.FMOpen.Text = "Open(O)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // FMAdd
            // 
            this.FMAdd.Name = "FMAdd";
            this.FMAdd.Size = new System.Drawing.Size(193, 26);
            this.FMAdd.Text = "Add(D)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // FMClose
            // 
            this.FMClose.Name = "FMClose";
            this.FMClose.Size = new System.Drawing.Size(193, 26);
            this.FMClose.Text = "Close(C)";
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoUToolStripMenuItem,
            this.redoRToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.editEToolStripMenuItem.Text = "Edit(E)";
            // 
            // undoUToolStripMenuItem
            // 
            this.undoUToolStripMenuItem.Name = "undoUToolStripMenuItem";
            this.undoUToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.undoUToolStripMenuItem.Text = "Undo(U)";
            // 
            // redoRToolStripMenuItem
            // 
            this.redoRToolStripMenuItem.Name = "redoRToolStripMenuItem";
            this.redoRToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.redoRToolStripMenuItem.Text = "Redo(R)";
            // 
            // vewVToolStripMenuItem
            // 
            this.vewVToolStripMenuItem.Name = "vewVToolStripMenuItem";
            this.vewVToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.vewVToolStripMenuItem.Text = "View(V)";
            // 
            // toolsTToolStripMenuItem
            // 
            this.toolsTToolStripMenuItem.Name = "toolsTToolStripMenuItem";
            this.toolsTToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.toolsTToolStripMenuItem.Text = "Tools(T)";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.optionToolStripMenuItem.Text = "Option(O)";
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoButton,
            this.RedoButton,
            this.toolStripSeparator3,
            this.NewProjectButton,
            this.OpenFileButton,
            this.SaveButton,
            this.toolStripSeparator4,
            this.ExecutionButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 28);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1582, 27);
            this.TopToolStrip.TabIndex = 4;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(39, 24);
            this.UndoButton.Text = "Undo(Corl+Z)";
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(39, 24);
            this.RedoButton.Text = "Redo(Ctrl+Y)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectButton.Image")));
            this.NewProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(39, 24);
            this.NewProjectButton.Text = "toolStripButton3";
            this.NewProjectButton.ToolTipText = "New Project(Ctrl+Shift+N)";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(29, 24);
            this.OpenFileButton.Text = "Open(Ctrl+O)";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(29, 24);
            this.SaveButton.Text = "Save(Ctrl+S)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // ExecutionButton
            // 
            this.ExecutionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecutionButton.Image = ((System.Drawing.Image)(resources.GetObject("ExecutionButton.Image")));
            this.ExecutionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.Size = new System.Drawing.Size(29, 24);
            this.ExecutionButton.Text = "Execute(Ctrl+F5)";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SpriteList);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DebugPannel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ControlPannel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Editer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.FileViewer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BottomToolStrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1582, 798);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 55);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1582, 798);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1103, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 300);
            this.panel1.TabIndex = 4;
            // 
            // SpriteList
            // 
            this.SpriteList.HideSelection = false;
            this.SpriteList.Location = new System.Drawing.Point(1103, 334);
            this.SpriteList.Name = "SpriteList";
            this.SpriteList.Size = new System.Drawing.Size(486, 426);
            this.SpriteList.TabIndex = 0;
            this.SpriteList.UseCompatibleStateImageBehavior = false;
            // 
            // DebugPannel
            // 
            this.DebugPannel.Location = new System.Drawing.Point(0, 596);
            this.DebugPannel.Name = "DebugPannel";
            this.DebugPannel.Size = new System.Drawing.Size(1121, 164);
            this.DebugPannel.TabIndex = 0;
            // 
            // ControlPannel
            // 
            this.ControlPannel.AutoScroll = true;
            this.ControlPannel.Controls.Add(this.testObject);
            this.ControlPannel.Location = new System.Drawing.Point(206, 28);
            this.ControlPannel.Name = "ControlPannel";
            this.ControlPannel.Size = new System.Drawing.Size(304, 562);
            this.ControlPannel.TabIndex = 3;
            // 
            // Editer
            // 
            this.Editer.Controls.Add(this.tabPage1);
            this.Editer.Controls.Add(this.tabPage2);
            this.Editer.Location = new System.Drawing.Point(516, 3);
            this.Editer.Multiline = true;
            this.Editer.Name = "Editer";
            this.Editer.SelectedIndex = 0;
            this.Editer.Size = new System.Drawing.Size(581, 587);
            this.Editer.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileViewer
            // 
            this.FileViewer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FileViewer.Location = new System.Drawing.Point(0, 0);
            this.FileViewer.Name = "FileViewer";
            this.FileViewer.Size = new System.Drawing.Size(200, 590);
            this.FileViewer.TabIndex = 1;
            // 
            // BottomToolStrip
            // 
            this.BottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadProgressBar,
            this.toolStripSeparator5,
            this.PicturesURL});
            this.BottomToolStrip.Location = new System.Drawing.Point(0, 767);
            this.BottomToolStrip.Name = "BottomToolStrip";
            this.BottomToolStrip.Size = new System.Drawing.Size(1582, 31);
            this.BottomToolStrip.TabIndex = 0;
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.Size = new System.Drawing.Size(150, 28);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // PicturesURL
            // 
            this.PicturesURL.Enabled = false;
            this.PicturesURL.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.PicturesURL.Name = "PicturesURL";
            this.PicturesURL.Size = new System.Drawing.Size(300, 31);
            this.PicturesURL.Text = "Using This Images: https://icons8.com";
            // 
            // testObject
            // 
            this.testObject.AllowDrop = true;
            this.testObject.BackColor = System.Drawing.Color.Red;
            this.testObject.Location = new System.Drawing.Point(3, 3);
            this.testObject.Name = "testObject";
            this.testObject.Size = new System.Drawing.Size(155, 98);
            this.testObject.TabIndex = 5;
            this.testObject.DragDrop += new System.Windows.Forms.DragEventHandler(this.testObject_DragDrop);
            this.testObject.DragEnter += new System.Windows.Forms.DragEventHandler(this.testObject_DragEnter);
            this.testObject.DragOver += new System.Windows.Forms.DragEventHandler(this.testObject_DragOver);
            this.testObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testObject_MouseDown);
            this.testObject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.testObject_MouseMove);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.MenuBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainWindow";
            this.Text = "ProgLab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ControlPannel.ResumeLayout(false);
            this.Editer.ResumeLayout(false);
            this.BottomToolStrip.ResumeLayout(false);
            this.BottomToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vewVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FMNewProject;
        private System.Windows.Forms.ToolStripMenuItem FMOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FMAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FMClose;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton NewProjectButton;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSplitButton UndoButton;
        private System.Windows.Forms.ToolStripSplitButton RedoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ExecutionButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip BottomToolStrip;
        private System.Windows.Forms.ToolStripTextBox PicturesURL;
        private System.Windows.Forms.ToolStripProgressBar LoadProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TreeView FileViewer;
        private System.Windows.Forms.ToolStripMenuItem undoUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoRToolStripMenuItem;
        private System.Windows.Forms.Panel DebugPannel;
        private System.Windows.Forms.Panel ControlPannel;
        private System.Windows.Forms.TabControl Editer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView SpriteList;
        private System.Windows.Forms.Panel testObject;
    }
}

