
namespace RequestsGenerator
{
	partial class FormCreateRequest
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
			this.btSaveRequest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btEditXML = new System.Windows.Forms.Button();
			this.cbFsrarId = new System.Windows.Forms.ComboBox();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btSaveRequest, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 230);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btEditXML, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbFsrarId, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.tbComment, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 187);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btSaveRequest
			// 
			this.btSaveRequest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSaveRequest.Location = new System.Drawing.Point(4, 199);
			this.btSaveRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btSaveRequest.Name = "btSaveRequest";
			this.btSaveRequest.Size = new System.Drawing.Size(335, 27);
			this.btSaveRequest.TabIndex = 1;
			this.btSaveRequest.Text = "Сохранить запрос";
			this.btSaveRequest.UseVisualStyleBackColor = true;
			this.btSaveRequest.Click += new System.EventHandler(this.btSaveRequest_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Запрос XML:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "ФСРАР ID:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Примечание:";
			// 
			// btEditXML
			// 
			this.btEditXML.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEditXML.Location = new System.Drawing.Point(165, 19);
			this.btEditXML.Name = "btEditXML";
			this.btEditXML.Size = new System.Drawing.Size(138, 23);
			this.btEditXML.TabIndex = 3;
			this.btEditXML.Text = "Редактировать";
			this.btEditXML.UseVisualStyleBackColor = true;
			this.btEditXML.Click += new System.EventHandler(this.btEditXML_Click);
			// 
			// cbFsrarId
			// 
			this.cbFsrarId.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFsrarId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFsrarId.FormattingEnabled = true;
			this.cbFsrarId.Items.AddRange(new object[] {
            "010060693049",
            "020000559704"});
			this.cbFsrarId.Location = new System.Drawing.Point(164, 82);
			this.cbFsrarId.Name = "cbFsrarId";
			this.cbFsrarId.Size = new System.Drawing.Size(140, 24);
			this.cbFsrarId.TabIndex = 4;
			// 
			// tbComment
			// 
			this.tbComment.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbComment.Location = new System.Drawing.Point(163, 144);
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new System.Drawing.Size(142, 23);
			this.tbComment.TabIndex = 5;
			// 
			// FormCreateRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 230);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormCreateRequest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Создание запроса";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btEditXML;
		private System.Windows.Forms.ComboBox cbFsrarId;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.Button btSaveRequest;
	}
}