using System.Drawing;
using System.Reflection;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelMesh = new System.Windows.Forms.Label();
            this.DropdownMesh = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelFocalLength = new System.Windows.Forms.Label();
            this.NumericUpDownFocalLength = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelOffsetXYZ = new System.Windows.Forms.Label();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnglePerSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShowCorners = new System.Windows.Forms.CheckBox();
            this.MeshRenderWindow = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.autoRotate = new System.Windows.Forms.CheckBox();
            this.TrackBarRotateModel = new System.Windows.Forms.TrackBar();
            this.ButtonResetRotateModel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFocalLength)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnglePerSecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshRenderWindow)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotateModel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MeshRenderWindow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.30612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.693877F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowCorners);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 525);
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
            this.DropdownMesh.DisplayMember = "Cube";
            this.DropdownMesh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownMesh.FormattingEnabled = true;
            this.DropdownMesh.Items.AddRange(new object[] {
            "Cube",
            "Pyramid",
            "Sphere"});
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
            this.NumericUpDownFocalLength.DecimalPlaces = 1;
            this.NumericUpDownFocalLength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownFocalLength.Location = new System.Drawing.Point(78, 3);
            this.NumericUpDownFocalLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownFocalLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumericUpDownFocalLength.Name = "NumericUpDownFocalLength";
            this.NumericUpDownFocalLength.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownFocalLength.TabIndex = 2;
            this.NumericUpDownFocalLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownFocalLength.ValueChanged += new System.EventHandler(this.NumericUpDownFocalLength_ValueChanged);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.LabelOffsetXYZ);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownX);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownY);
            this.flowLayoutPanel6.Controls.Add(this.NumericUpDownZ);
            this.flowLayoutPanel6.Controls.Add(this.button1);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 69);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(307, 27);
            this.flowLayoutPanel6.TabIndex = 8;
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
            // NumericUpDownX
            // 
            this.NumericUpDownX.DecimalPlaces = 1;
            this.NumericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownX.Location = new System.Drawing.Point(80, 3);
            this.NumericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownX.TabIndex = 2;
            this.NumericUpDownX.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // NumericUpDownY
            // 
            this.NumericUpDownY.DecimalPlaces = 1;
            this.NumericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownY.Location = new System.Drawing.Point(128, 3);
            this.NumericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownY.Name = "NumericUpDownY";
            this.NumericUpDownY.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownY.TabIndex = 3;
            this.NumericUpDownY.ValueChanged += new System.EventHandler(this.NumericUpDownY_ValueChanged);
            // 
            // NumericUpDownZ
            // 
            this.NumericUpDownZ.DecimalPlaces = 1;
            this.NumericUpDownZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownZ.Location = new System.Drawing.Point(176, 3);
            this.NumericUpDownZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownZ.Name = "NumericUpDownZ";
            this.NumericUpDownZ.Size = new System.Drawing.Size(42, 20);
            this.NumericUpDownZ.TabIndex = 4;
            this.NumericUpDownZ.ValueChanged += new System.EventHandler(this.NumericUpDownZ_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.AnglePerSecondUpDown);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 102);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(281, 27);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotational speed";
            // 
            // AnglePerSecondUpDown
            // 
            this.AnglePerSecondUpDown.Location = new System.Drawing.Point(96, 3);
            this.AnglePerSecondUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AnglePerSecondUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AnglePerSecondUpDown.Name = "AnglePerSecondUpDown";
            this.AnglePerSecondUpDown.Size = new System.Drawing.Size(74, 20);
            this.AnglePerSecondUpDown.TabIndex = 2;
            this.AnglePerSecondUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.AnglePerSecondUpDown.ValueChanged += new System.EventHandler(this.AnglePerSecondUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "°⁄s";
            // 
            // checkBoxShowCorners
            // 
            this.checkBoxShowCorners.AutoSize = true;
            this.checkBoxShowCorners.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxShowCorners.Location = new System.Drawing.Point(3, 135);
            this.checkBoxShowCorners.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.checkBoxShowCorners.Name = "checkBoxShowCorners";
            this.checkBoxShowCorners.Padding = new System.Windows.Forms.Padding(4, 12, 0, 0);
            this.checkBoxShowCorners.Size = new System.Drawing.Size(96, 29);
            this.checkBoxShowCorners.TabIndex = 6;
            this.checkBoxShowCorners.Text = "Show Corners";
            this.checkBoxShowCorners.UseVisualStyleBackColor = true;
            this.checkBoxShowCorners.CheckedChanged += new System.EventHandler(this.checkBoxShowCorners_CheckedChanged);
            // 
            // MeshRenderWindow
            // 
            this.MeshRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeshRenderWindow.Location = new System.Drawing.Point(319, 3);
            this.MeshRenderWindow.Name = "MeshRenderWindow";
            this.MeshRenderWindow.Size = new System.Drawing.Size(645, 525);
            this.MeshRenderWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MeshRenderWindow.TabIndex = 5;
            this.MeshRenderWindow.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.autoRotate);
            this.flowLayoutPanel5.Controls.Add(this.TrackBarRotateModel);
            this.flowLayoutPanel5.Controls.Add(this.ButtonResetRotateModel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(319, 534);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(645, 51);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // autoRotate
            // 
            this.autoRotate.AutoSize = true;
            this.autoRotate.Checked = true;
            this.autoRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRotate.Location = new System.Drawing.Point(3, 3);
            this.autoRotate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.autoRotate.Name = "autoRotate";
            this.autoRotate.Padding = new System.Windows.Forms.Padding(4, 12, 0, 0);
            this.autoRotate.Size = new System.Drawing.Size(82, 29);
            this.autoRotate.TabIndex = 9;
            this.autoRotate.Text = "Auto rotate";
            this.autoRotate.UseVisualStyleBackColor = true;
            this.autoRotate.CheckedChanged += new System.EventHandler(this.autoRotate_CheckedChanged);
            // 
            // TrackBarRotateModel
            // 
            this.TrackBarRotateModel.AllowDrop = true;
            this.TrackBarRotateModel.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBarRotateModel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.TrackBarRotateModel.LargeChange = 10;
            this.TrackBarRotateModel.Location = new System.Drawing.Point(85, 15);
            this.TrackBarRotateModel.Margin = new System.Windows.Forms.Padding(0, 15, 0, 3);
            this.TrackBarRotateModel.Maximum = 1800;
            this.TrackBarRotateModel.Minimum = -1800;
            this.TrackBarRotateModel.Name = "TrackBarRotateModel";
            this.TrackBarRotateModel.Size = new System.Drawing.Size(475, 50);
            this.TrackBarRotateModel.TabIndex = 2;
            this.TrackBarRotateModel.TickFrequency = 0;
            this.TrackBarRotateModel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarRotateModel.Scroll += new System.EventHandler(this.TrackBarRotateModel_Scroll);
            // 
            // ButtonResetRotateModel
            // 
            this.ButtonResetRotateModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonResetRotateModel.Location = new System.Drawing.Point(563, 14);
            this.ButtonResetRotateModel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ButtonResetRotateModel.Name = "ButtonResetRotateModel";
            this.ButtonResetRotateModel.Size = new System.Drawing.Size(60, 23);
            this.ButtonResetRotateModel.TabIndex = 3;
            this.ButtonResetRotateModel.Text = "Reset";
            this.ButtonResetRotateModel.UseVisualStyleBackColor = true;
            this.ButtonResetRotateModel.Click += new System.EventHandler(this.ButtonResetRotateModel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(967, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3D Renderer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownFocalLength)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnglePerSecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshRenderWindow)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotateModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox DropdownMesh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label LabelMesh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LabelFocalLength;
        private System.Windows.Forms.NumericUpDown NumericUpDownFocalLength;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.NumericUpDown NumericUpDownX;
        private System.Windows.Forms.NumericUpDown NumericUpDownY;
        private System.Windows.Forms.NumericUpDown NumericUpDownZ;
        private System.Windows.Forms.Label LabelOffsetXYZ;
        private System.Windows.Forms.TrackBar TrackBarRotateModel;
        private System.Windows.Forms.Button ButtonResetRotateModel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.PictureBox MeshRenderWindow;
        private System.Windows.Forms.CheckBox checkBoxShowCorners;
        private System.Windows.Forms.CheckBox autoRotate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AnglePerSecondUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

