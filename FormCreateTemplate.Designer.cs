
namespace RequestsGenerator
{
	partial class FormCreateTemplate
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbTypes = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.cbFsrarId = new System.Windows.Forms.ComboBox();
			this.btBrowseXML = new System.Windows.Forms.Button();
			this.btSaveTemplate = new System.Windows.Forms.Button();
			this.lbBrowseStatus = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btSaveTemplate, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbBrowseStatus, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 297);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Controls.Add(this.cbTypes, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbFsrarId, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.btBrowseXML, 1, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 211);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// cbTypes
			// 
			this.cbTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTypes.DropDownWidth = 500;
			this.cbTypes.FormattingEnabled = true;
			this.cbTypes.Location = new System.Drawing.Point(136, 119);
			this.cbTypes.Name = "cbTypes";
			this.cbTypes.Size = new System.Drawing.Size(181, 24);
			this.cbTypes.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "XML шаблон:";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя запроса:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "ФСРАР ID:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Тип запроса:";
			// 
			// tbName
			// 
			this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbName.Location = new System.Drawing.Point(136, 14);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(181, 23);
			this.tbName.TabIndex = 4;
			// 
			// cbFsrarId
			// 
			this.cbFsrarId.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFsrarId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFsrarId.FormattingEnabled = true;
			this.cbFsrarId.Items.AddRange(new object[] {
            "010060693049",
            "020000559704"});
			this.cbFsrarId.Location = new System.Drawing.Point(136, 67);
			this.cbFsrarId.Name = "cbFsrarId";
			this.cbFsrarId.Size = new System.Drawing.Size(180, 24);
			this.cbFsrarId.TabIndex = 5;
			// 
			// btBrowseXML
			// 
			this.btBrowseXML.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btBrowseXML.Location = new System.Drawing.Point(134, 172);
			this.btBrowseXML.Name = "btBrowseXML";
			this.btBrowseXML.Size = new System.Drawing.Size(184, 23);
			this.btBrowseXML.TabIndex = 7;
			this.btBrowseXML.Text = "Обзор";
			this.btBrowseXML.UseVisualStyleBackColor = true;
			this.btBrowseXML.Click += new System.EventHandler(this.btBrowse_Click);
			// 
			// btSaveTemplate
			// 
			this.btSaveTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSaveTemplate.Location = new System.Drawing.Point(4, 252);
			this.btSaveTemplate.Margin = new System.Windows.Forms.Padding(4);
			this.btSaveTemplate.Name = "btSaveTemplate";
			this.btSaveTemplate.Size = new System.Drawing.Size(324, 41);
			this.btSaveTemplate.TabIndex = 1;
			this.btSaveTemplate.Text = "Сохранить шаблон";
			this.btSaveTemplate.UseVisualStyleBackColor = true;
			this.btSaveTemplate.Click += new System.EventHandler(this.btSave_Click);
			// 
			// lbBrowseStatus
			// 
			this.lbBrowseStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbBrowseStatus.AutoSize = true;
			this.lbBrowseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbBrowseStatus.ForeColor = System.Drawing.Color.Red;
			this.lbBrowseStatus.Location = new System.Drawing.Point(78, 225);
			this.lbBrowseStatus.Name = "lbBrowseStatus";
			this.lbBrowseStatus.Size = new System.Drawing.Size(176, 17);
			this.lbBrowseStatus.TabIndex = 2;
			this.lbBrowseStatus.Text = "Шаблон XML не выбран...";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.xml";
			this.openFileDialog1.Filter = "XML файлы|*.xml";
			// 
			// FormCreateTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 297);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormCreateTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Создание нового типа запроса";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btSaveTemplate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTypes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.ComboBox cbFsrarId;
		private System.Windows.Forms.Button btBrowseXML;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label lbBrowseStatus;
	}
}