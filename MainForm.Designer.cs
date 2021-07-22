
namespace RequestsGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TemplatesListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miAddTemplate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.miDeleteTemplate = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.RepliesListView = new System.Windows.Forms.ListView();
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.RequestsListView = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miCreateRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.miSendRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.miSaveRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.miDeleteRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.TemplatesListView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 661);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// TemplatesListView
			// 
			this.TemplatesListView.BackColor = System.Drawing.SystemColors.Window;
			this.TemplatesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TemplatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.TemplatesListView.ContextMenuStrip = this.contextMenuStrip1;
			this.TemplatesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TemplatesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TemplatesListView.ForeColor = System.Drawing.SystemColors.WindowText;
			this.TemplatesListView.FullRowSelect = true;
			this.TemplatesListView.HideSelection = false;
			this.TemplatesListView.Location = new System.Drawing.Point(1, 1);
			this.TemplatesListView.Margin = new System.Windows.Forms.Padding(1);
			this.TemplatesListView.MultiSelect = false;
			this.TemplatesListView.Name = "TemplatesListView";
			this.TemplatesListView.Size = new System.Drawing.Size(387, 659);
			this.TemplatesListView.TabIndex = 0;
			this.TemplatesListView.UseCompatibleStateImageBehavior = false;
			this.TemplatesListView.View = System.Windows.Forms.View.Details;
			this.TemplatesListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.TemplatesListView_DrawColumnHeader);
			this.TemplatesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.TemplatesListView_ItemSelectionChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Название";
			this.columnHeader2.Width = 221;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ФСРАР ID";
			this.columnHeader3.Width = 100;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddTemplate,
            this.toolStripMenuItem1,
            this.miDeleteTemplate});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(252, 54);
			// 
			// miAddTemplate
			// 
			this.miAddTemplate.Name = "miAddTemplate";
			this.miAddTemplate.Size = new System.Drawing.Size(251, 22);
			this.miAddTemplate.Text = "Создать новый шаблон запроса";
			this.miAddTemplate.Click += new System.EventHandler(this.miAddTemplate_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
			// 
			// miDeleteTemplate
			// 
			this.miDeleteTemplate.Name = "miDeleteTemplate";
			this.miDeleteTemplate.Size = new System.Drawing.Size(251, 22);
			this.miDeleteTemplate.Text = "Удалить шаблон запроса";
			this.miDeleteTemplate.Click += new System.EventHandler(this.miDeleteTemplate_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.RepliesListView, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.RequestsListView, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textEditorControl1, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(389, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(910, 661);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// RepliesListView
			// 
			this.RepliesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RepliesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
			this.RepliesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RepliesListView.FullRowSelect = true;
			this.RepliesListView.HideSelection = false;
			this.RepliesListView.Location = new System.Drawing.Point(1, 265);
			this.RepliesListView.Margin = new System.Windows.Forms.Padding(1);
			this.RepliesListView.MultiSelect = false;
			this.RepliesListView.Name = "RepliesListView";
			this.RepliesListView.Size = new System.Drawing.Size(908, 130);
			this.RepliesListView.TabIndex = 2;
			this.RepliesListView.UseCompatibleStateImageBehavior = false;
			this.RepliesListView.View = System.Windows.Forms.View.Details;
			this.RepliesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.RepliesListView_ItemSelectionChanged);
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "ID";
			this.columnHeader16.Width = 79;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "ID запроса";
			this.columnHeader17.Width = 108;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Дата ответа";
			this.columnHeader18.Width = 172;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Содержание";
			this.columnHeader19.Width = 476;
			// 
			// RequestsListView
			// 
			this.RequestsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RequestsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7});
			this.RequestsListView.ContextMenuStrip = this.contextMenuStrip2;
			this.RequestsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RequestsListView.FullRowSelect = true;
			this.RequestsListView.HideSelection = false;
			this.RequestsListView.Location = new System.Drawing.Point(1, 1);
			this.RequestsListView.Margin = new System.Windows.Forms.Padding(1);
			this.RequestsListView.MultiSelect = false;
			this.RequestsListView.Name = "RequestsListView";
			this.RequestsListView.Size = new System.Drawing.Size(908, 262);
			this.RequestsListView.TabIndex = 1;
			this.RequestsListView.UseCompatibleStateImageBehavior = false;
			this.RequestsListView.View = System.Windows.Forms.View.Details;
			this.RequestsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.RequestsListView_ItemSelectionChanged);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "ID";
			this.columnHeader4.Width = 73;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Template ID";
			this.columnHeader5.Width = 114;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Дата";
			this.columnHeader6.Width = 219;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Примечание";
			this.columnHeader8.Width = 247;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Статус";
			this.columnHeader7.Width = 105;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateRequest,
            this.miSendRequest,
            this.toolStripMenuItem2,
            this.miSaveRequest,
            this.toolStripMenuItem3,
            this.miDeleteRequest});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(216, 104);
			// 
			// miCreateRequest
			// 
			this.miCreateRequest.Name = "miCreateRequest";
			this.miCreateRequest.Size = new System.Drawing.Size(215, 22);
			this.miCreateRequest.Text = "Создать запрос";
			this.miCreateRequest.Click += new System.EventHandler(this.miCreateRequest_Click);
			// 
			// miSendRequest
			// 
			this.miSendRequest.Name = "miSendRequest";
			this.miSendRequest.Size = new System.Drawing.Size(215, 22);
			this.miSendRequest.Text = "Отправить запрос";
			this.miSendRequest.Click += new System.EventHandler(this.miSendRequest_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
			// 
			// miSaveRequest
			// 
			this.miSaveRequest.Name = "miSaveRequest";
			this.miSaveRequest.Size = new System.Drawing.Size(215, 22);
			this.miSaveRequest.Text = "Сохранить запрос в файл";
			this.miSaveRequest.Click += new System.EventHandler(this.miSaveRequest_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 6);
			// 
			// miDeleteRequest
			// 
			this.miDeleteRequest.Name = "miDeleteRequest";
			this.miDeleteRequest.Size = new System.Drawing.Size(215, 22);
			this.miDeleteRequest.Text = "Удалить запрос";
			this.miDeleteRequest.Click += new System.EventHandler(this.miDeleteRequest_Click);
			// 
			// textEditorControl1
			// 
			this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textEditorControl1.IsReadOnly = false;
			this.textEditorControl1.Location = new System.Drawing.Point(1, 397);
			this.textEditorControl1.Margin = new System.Windows.Forms.Padding(1);
			this.textEditorControl1.Name = "textEditorControl1";
			this.textEditorControl1.Size = new System.Drawing.Size(908, 263);
			this.textEditorControl1.TabIndex = 3;
			this.textEditorControl1.Text = resources.GetString("textEditorControl1.Text");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1299, 661);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RequestsGenerator";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem miAddTemplate;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ToolStripMenuItem miDeleteTemplate;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
		public System.Windows.Forms.ListView RequestsListView;
		public System.Windows.Forms.ListView TemplatesListView;
		public System.Windows.Forms.ListView RepliesListView;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem miCreateRequest;
		private System.Windows.Forms.ToolStripMenuItem miSendRequest;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem miDeleteRequest;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem miSaveRequest;
	}
}

