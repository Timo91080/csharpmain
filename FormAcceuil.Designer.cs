namespace Projet_cours_1
{
    partial class FormAccueil
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private FlowLayoutPanel flowLayoutPanelBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            flowLayoutPanelBooks = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(335, 131);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(400, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(769, 126);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 30);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Rechercher";
            buttonSearch.Click += buttonSearch_Click;
            // 
            // flowLayoutPanelBooks
            // 
            flowLayoutPanelBooks.AutoScroll = true;
            flowLayoutPanelBooks.Location = new Point(256, 167);
            flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            flowLayoutPanelBooks.Size = new Size(760, 500);
            flowLayoutPanelBooks.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(420, 50);
            label1.Name = "label1";
            label1.Size = new Size(378, 37);
            label1.TabIndex = 3;
            label1.Text = "Bienvenue dans BiblioWorld";
          
            // 
            // FormAccueil
            // 
            ClientSize = new Size(1318, 731);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(flowLayoutPanelBooks);
            Name = "FormAccueil";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
