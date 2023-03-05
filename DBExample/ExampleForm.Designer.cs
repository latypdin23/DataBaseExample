
namespace DBExample
{
    partial class ExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoin = new System.Windows.Forms.ToolStripDropDownButton();
            this.innerJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.execution = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.txtSQL);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gridData);
            this.splitContainer.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 330;
            this.splitContainer.TabIndex = 0;
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSQL.Location = new System.Drawing.Point(0, 25);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(330, 425);
            this.txtSQL.TabIndex = 1;
            this.txtSQL.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelect,
            this.btnJoin,
            this.btnExecute});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(330, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 22);
            this.btnSelect.Text = "DML";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnJoin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.innerJoinToolStripMenuItem,
            this.leftJoinToolStripMenuItem,
            this.rightJoinToolStripMenuItem});
            this.btnJoin.Image = ((System.Drawing.Image)(resources.GetObject("btnJoin.Image")));
            this.btnJoin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(45, 22);
            this.btnJoin.Text = "JOIN";
            // 
            // innerJoinToolStripMenuItem
            // 
            this.innerJoinToolStripMenuItem.Name = "innerJoinToolStripMenuItem";
            this.innerJoinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.innerJoinToolStripMenuItem.Text = "Inner join";
            this.innerJoinToolStripMenuItem.Click += new System.EventHandler(this.innerJoinToolStripMenuItem_Click);
            // 
            // leftJoinToolStripMenuItem
            // 
            this.leftJoinToolStripMenuItem.Name = "leftJoinToolStripMenuItem";
            this.leftJoinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftJoinToolStripMenuItem.Text = "Left join";
            this.leftJoinToolStripMenuItem.Click += new System.EventHandler(this.leftJoinToolStripMenuItem_Click);
            // 
            // rightJoinToolStripMenuItem
            // 
            this.rightJoinToolStripMenuItem.Name = "rightJoinToolStripMenuItem";
            this.rightJoinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightJoinToolStripMenuItem.Text = "Right join";
            this.rightJoinToolStripMenuItem.Click += new System.EventHandler(this.rightJoinToolStripMenuItem_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(23, 22);
            this.btnExecute.Text = "Выполнить";
            // 
            // gridData
            // 
            this.gridData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(0, 25);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(466, 425);
            this.gridData.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.execution});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // execution
            // 
            this.execution.Name = "execution";
            this.execution.Size = new System.Drawing.Size(0, 22);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "ExampleForm";
            this.Text = "Пример";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton btnSelect;
        private System.Windows.Forms.ToolStripDropDownButton btnJoin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innerJoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftJoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightJoinToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripLabel execution;
    }
}

