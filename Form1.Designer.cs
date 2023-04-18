namespace _3DRenderer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelMesh = new System.Windows.Forms.Label();
            this.DropdownMesh = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelFocalLength = new System.Windows.Forms.Label();
            this.NumericUpDownFocalLength = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelShowFaces = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LabelOffsetXYZ = new System.Windows.Forms.Label();
            this.CheckBoxShowFaces = new System.Windows.Forms.CheckBox();
            this.TrackBarRotateModel = new System.Windows.Forms.TrackBar();
            this.ButtonResetRotateModel = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFocalLength)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotateModel)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.30612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.693877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 525);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.LabelMesh);
            this.flowLayoutPanel3.Controls.Add(this.DropdownMesh);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(281, 27);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // LabelMesh
            // 
            this.LabelMesh.AutoSize = true;
            this.LabelMesh.Location = new System.Drawing.Point(3, 0);
            this.LabelMesh.Name = "LabelMesh";
            this.LabelMesh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelMesh.Size = new System.Drawing.Size(33, 18);
            this.LabelMesh.TabIndex = 0;
            this.LabelMesh.Text = "Mesh";
            // 
            // DropdownMesh
            // 
            this.DropdownMesh.BackColor = System.Drawing.SystemColors.Window;
            this.DropdownMesh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownMesh.FormattingEnabled = true;
            this.DropdownMesh.Items.AddRange(new object[] {
            "Cube",
            "Pyramid"});
            this.DropdownMesh.Location = new System.Drawing.Point(42, 3);
            this.DropdownMesh.Name = "DropdownMesh";
            this.DropdownMesh.Size = new System.Drawing.Size(121, 21);
            this.DropdownMesh.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LabelFocalLength);
            this.flowLayoutPanel2.Controls.Add(this.NumericUpDownFocalLength);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(281, 27);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // LabelFocalLength
            // 
            this.LabelFocalLength.AutoSize = true;
            this.LabelFocalLength.Location = new System.Drawing.Point(3, 0);
            this.LabelFocalLength.Name = "LabelFocalLength";
            this.LabelFocalLength.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelFocalLength.Size = new System.Drawing.Size(69, 18);
            this.LabelFocalLength.TabIndex = 0;
            this.LabelFocalLength.Text = "Focal Length";
            // 
            // NumericUpDownFocalLength
            // 
            this.NumericUpDownFocalLength.Location = new System.Drawing.Point(78, 3);
            this.NumericUpDownFocalLength.Name = "NumericUpDownFocalLength";
            this.NumericUpDownFocalLength.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownFocalLength.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.LabelShowFaces);
            this.flowLayoutPanel4.Controls.Add(this.CheckBoxShowFaces);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 69);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(281, 27);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // LabelShowFaces
            // 
            this.LabelShowFaces.AutoSize = true;
            this.LabelShowFaces.Location = new System.Drawing.Point(3, 0);
            this.LabelShowFaces.Name = "LabelShowFaces";
            this.LabelShowFaces.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelShowFaces.Size = new System.Drawing.Size(66, 18);
            this.LabelShowFaces.TabIndex = 0;
            this.LabelShowFaces.Text = "Show Faces";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.LabelOffsetXYZ);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownX);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownY);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownZ);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 102);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(281, 27);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Location = new System.Drawing.Point(80, 3);
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownX.TabIndex = 2;
            // 
            // NumericUpDownY
            // 
            this.NumericUpDownY.Location = new System.Drawing.Point(128, 3);
            this.NumericUpDownY.Name = "NumericUpDownY";
            this.NumericUpDownY.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownY.TabIndex = 3;
            // 
            // NumericUpDownZ
            // 
            this.NumericUpDownZ.Location = new System.Drawing.Point(176, 3);
            this.NumericUpDownZ.Name = "NumericUpDownZ";
            this.NumericUpDownZ.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownZ.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LabelOffsetXYZ
            // 
            this.LabelOffsetXYZ.AutoSize = true;
            this.LabelOffsetXYZ.Location = new System.Drawing.Point(3, 0);
            this.LabelOffsetXYZ.Name = "LabelOffsetXYZ";
            this.LabelOffsetXYZ.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelOffsetXYZ.Size = new System.Drawing.Size(71, 18);
            this.LabelOffsetXYZ.TabIndex = 5;
            this.LabelOffsetXYZ.Text = "Offset ( x,y,z )";
            // 
            // CheckBoxShowFaces
            // 
            this.CheckBoxShowFaces.AutoSize = true;
            this.CheckBoxShowFaces.Location = new System.Drawing.Point(75, 3);
            this.CheckBoxShowFaces.Name = "CheckBoxShowFaces";
            this.CheckBoxShowFaces.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxShowFaces.TabIndex = 1;
            this.CheckBoxShowFaces.UseVisualStyleBackColor = true;
            // 
            // TrackBarRotateModel
            // 
            this.TrackBarRotateModel.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBarRotateModel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.TrackBarRotateModel.LargeChange = 10;
            this.TrackBarRotateModel.Location = new System.Drawing.Point(3, 15);
            this.TrackBarRotateModel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.TrackBarRotateModel.Maximum = 360;
            this.TrackBarRotateModel.Minimum = -360;
            this.TrackBarRotateModel.Name = "TrackBarRotateModel";
            this.TrackBarRotateModel.Size = new System.Drawing.Size(599, 50);
            this.TrackBarRotateModel.TabIndex = 2;
            this.TrackBarRotateModel.TickFrequency = 0;
            this.TrackBarRotateModel.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // ButtonResetRotateModel
            // 
            this.ButtonResetRotateModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonResetRotateModel.Location = new System.Drawing.Point(608, 14);
            this.ButtonResetRotateModel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ButtonResetRotateModel.Name = "ButtonResetRotateModel";
            this.ButtonResetRotateModel.Size = new System.Drawing.Size(60, 23);
            this.ButtonResetRotateModel.TabIndex = 3;
            this.ButtonResetRotateModel.Text = "Reset";
            this.ButtonResetRotateModel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.TrackBarRotateModel);
            this.flowLayoutPanel5.Controls.Add(this.ButtonResetRotateModel);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(293, 534);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(671, 51);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(967, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3D Renderer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFocalLength)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotateModel)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox DropdownMesh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label LabelMesh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LabelFocalLength;
        private System.Windows.Forms.NumericUpDown NumericUpDownFocalLength;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label LabelShowFaces;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.NumericUpDown NumericUpDownX;
        private System.Windows.Forms.NumericUpDown NumericUpDownY;
        private System.Windows.Forms.NumericUpDown NumericUpDownZ;
        private System.Windows.Forms.Label LabelOffsetXYZ;
        private System.Windows.Forms.CheckBox CheckBoxShowFaces;
        private System.Windows.Forms.TrackBar TrackBarRotateModel;
        private System.Windows.Forms.Button ButtonResetRotateModel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}

