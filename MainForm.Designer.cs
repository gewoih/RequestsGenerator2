
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.RequestsListView = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TemplatesListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miAddTemplate = new System.Windows.Forms.ToolStripMenuItem();
			this.miDeleteTemplate = new System.Windows.Forms.ToolStripMenuItem();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.RequestsListView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TemplatesListView, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 661F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 661);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// RequestsListView
			// 
			this.RequestsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RequestsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7});
			this.RequestsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RequestsListView.FullRowSelect = true;
			this.RequestsListView.HideSelection = false;
			this.RequestsListView.Location = new System.Drawing.Point(393, 4);
			this.RequestsListView.Margin = new System.Windows.Forms.Padding(4);
			this.RequestsListView.MultiSelect = false;
			this.RequestsListView.Name = "RequestsListView";
			this.RequestsListView.Size = new System.Drawing.Size(902, 653);
			this.RequestsListView.TabIndex = 1;
			this.RequestsListView.UseCompatibleStateImageBehavior = false;
			this.RequestsListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "ID";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Template ID";
			this.columnHeader5.Width = 114;
			// 
			// columnHeader6
			// 
			this.columnHeader6.DisplayIndex = 3;
			this.columnHeader6.Text = "Дата";
			this.columnHeader6.Width = 120;
			// 
			// columnHeader7
			// 
			this.columnHeader7.DisplayIndex = 5;
			this.columnHeader7.Text = "Статус";
			this.columnHeader7.Width = 105;
			// 
			// columnHeader8
			// 
			this.columnHeader8.DisplayIndex = 5;
			this.columnHeader8.Text = "Примечание";
			this.columnHeader8.Width = 247;
			// 
			// TemplatesListView
			// 
			this.TemplatesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TemplatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.TemplatesListView.ContextMenuStrip = this.contextMenuStrip1;
			this.TemplatesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TemplatesListView.FullRowSelect = true;
			this.TemplatesListView.HideSelection = false;
			this.TemplatesListView.Location = new System.Drawing.Point(4, 4);
			this.TemplatesListView.Margin = new System.Windows.Forms.Padding(4);
			this.TemplatesListView.MultiSelect = false;
			this.TemplatesListView.Name = "TemplatesListView";
			this.TemplatesListView.Size = new System.Drawing.Size(381, 653);
			this.TemplatesListView.TabIndex = 0;
			this.TemplatesListView.UseCompatibleStateImageBehavior = false;
			this.TemplatesListView.View = System.Windows.Forms.View.Details;
			this.TemplatesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.TemplatesListView_ItemSelectionChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Название";
			this.columnHeader2.Width = 180;
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
            this.miDeleteTemplate});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(252, 48);
			// 
			// miAddTemplate
			// 
			this.miAddTemplate.Name = "miAddTemplate";
			this.miAddTemplate.Size = new System.Drawing.Size(251, 22);
			this.miAddTemplate.Text = "Создать новый шаблон запроса";
			// 
			// miDeleteTemplate
			// 
			this.miDeleteTemplate.Name = "miDeleteTemplate";
			this.miDeleteTemplate.Size = new System.Drawing.Size(251, 22);
			this.miDeleteTemplate.Text = "Удалить шаблон запроса";
			// 
			// columnHeader9
			// 
			this.columnHeader9.DisplayIndex = 3;
			this.columnHeader9.Text = "Query ID";
			this.columnHeader9.Width = 81;
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
			this.Text = "MainForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
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
		private System.Windows.Forms.ListView RequestsListView;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ListView TemplatesListView;
		private System.Windows.Forms.ColumnHeader columnHeader9;
	}
}

