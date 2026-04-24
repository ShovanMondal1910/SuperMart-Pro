namespace SuperMart_Pro.View.Product
{
    partial class UpdateProductGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            SearchgroupBox = new GroupBox();
            Searchbutton = new Button();
            SearchtextBox = new TextBox();
            ProductIDlabel = new Label();
            ProductIDtextBox = new TextBox();
            ProductNamelabel = new Label();
            ProductNametextBox = new TextBox();
            Brandlabel = new Label();
            BrandtextBox = new TextBox();
            Photolabel = new Label();
            PhotopictureBox = new PictureBox();
            BrowsePhotobutton = new Button();
            ProductTypelabel = new Label();
            ProductTypetextBox = new TextBox();
            ProductCategorylabel = new Label();
            ProductCategorytextBox = new TextBox();
            Barcodelabel = new Label();
            BarcodetextBox = new TextBox();
            SKUlabel = new Label();
            SKUtextBox = new TextBox();
            Unitlabel = new Label();
            UnittextBox = new TextBox();
            ExpiryDatelabel = new Label();
            ExpiryDatedatePicker = new DateTimePicker();
            StockQuantitylabel = new Label();
            StockQuantitytextBox = new TextBox();
            Weightlabel = new Label();
            WeighttextBox = new TextBox();
            TotalSaleQuantitylabel = new Label();
            TotalSaleQuantitytextBox = new TextBox();
            ReorderLevellabel = new Label();
            ReorderLeveltextBox = new TextBox();
            MinStockLevellabel = new Label();
            MinStockLeveltextBox = new TextBox();
            IsExpirablecheckBox = new CheckBox();
            SupplierIDlabel = new Label();
            SupplierIDtextBox = new TextBox();
            BuyingPricelabel = new Label();
            BuyingPricetextBox = new TextBox();
            SellingPricelabel = new Label();
            SellingPricetextBox = new TextBox();
            Discountlabel = new Label();
            DiscounttextBox = new TextBox();
            Taxlabel = new Label();
            TaxtextBox = new TextBox();
            MRPlabel = new Label();
            MRPtextBox = new TextBox();
            IsActivecheckBox = new CheckBox();
            ReturnablecheckBox = new CheckBox();
            Savebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            SearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            SuspendLayout();
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(Searchbutton);
            SearchgroupBox.Controls.Add(SearchtextBox);
            SearchgroupBox.Location = new Point(356, 13);
            SearchgroupBox.Name = "SearchgroupBox";
            SearchgroupBox.Size = new Size(441, 80);
            SearchgroupBox.TabIndex = 1;
            SearchgroupBox.TabStop = false;
            SearchgroupBox.Text = "Search Product";
            // 
            // Searchbutton
            // 
            Searchbutton.Location = new Point(341, 28);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(75, 33);
            Searchbutton.TabIndex = 1;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = true;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(45, 28);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(263, 29);
            SearchtextBox.TabIndex = 0;
            // 
            // ProductIDlabel
            // 
            ProductIDlabel.Anchor = AnchorStyles.None;
            ProductIDlabel.AutoSize = true;
            ProductIDlabel.Location = new Point(99, 120);
            ProductIDlabel.Name = "ProductIDlabel";
            ProductIDlabel.Size = new Size(103, 21);
            ProductIDlabel.TabIndex = 2;
            ProductIDlabel.Text = "Product ID :";
            // 
            // ProductIDtextBox
            // 
            ProductIDtextBox.Anchor = AnchorStyles.None;
            ProductIDtextBox.Location = new Point(266, 117);
            ProductIDtextBox.Name = "ProductIDtextBox";
            ProductIDtextBox.ReadOnly = true;
            ProductIDtextBox.Size = new Size(290, 29);
            ProductIDtextBox.TabIndex = 3;
            // 
            // ProductNamelabel
            // 
            ProductNamelabel.Anchor = AnchorStyles.None;
            ProductNamelabel.AutoSize = true;
            ProductNamelabel.Location = new Point(75, 165);
            ProductNamelabel.Name = "ProductNamelabel";
            ProductNamelabel.Size = new Size(127, 21);
            ProductNamelabel.TabIndex = 4;
            ProductNamelabel.Text = "Product Name :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Anchor = AnchorStyles.None;
            ProductNametextBox.Location = new Point(266, 162);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(290, 29);
            ProductNametextBox.TabIndex = 5;
            // 
            // Brandlabel
            // 
            Brandlabel.Anchor = AnchorStyles.None;
            Brandlabel.AutoSize = true;
            Brandlabel.Location = new Point(138, 210);
            Brandlabel.Name = "Brandlabel";
            Brandlabel.Size = new Size(64, 21);
            Brandlabel.TabIndex = 6;
            Brandlabel.Text = "Brand :";
            // 
            // BrandtextBox
            // 
            BrandtextBox.Anchor = AnchorStyles.None;
            BrandtextBox.Location = new Point(266, 207);
            BrandtextBox.Name = "BrandtextBox";
            BrandtextBox.Size = new Size(290, 29);
            BrandtextBox.TabIndex = 7;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.None;
            Photolabel.AutoSize = true;
            Photolabel.Location = new Point(138, 320);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(64, 21);
            Photolabel.TabIndex = 8;
            Photolabel.Text = "Photo :";
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.Anchor = AnchorStyles.None;
            PhotopictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotopictureBox.Location = new Point(266, 253);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(158, 180);
            PhotopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotopictureBox.TabIndex = 9;
            PhotopictureBox.TabStop = false;
            // 
            // BrowsePhotobutton
            // 
            BrowsePhotobutton.Anchor = AnchorStyles.None;
            BrowsePhotobutton.Location = new Point(454, 320);
            BrowsePhotobutton.Name = "BrowsePhotobutton";
            BrowsePhotobutton.Size = new Size(90, 30);
            BrowsePhotobutton.TabIndex = 10;
            BrowsePhotobutton.Text = "Browse";
            BrowsePhotobutton.UseVisualStyleBackColor = true;
            BrowsePhotobutton.Click += BrowsePhotobutton_Click;
            // 
            // ProductTypelabel
            // 
            ProductTypelabel.Anchor = AnchorStyles.None;
            ProductTypelabel.AutoSize = true;
            ProductTypelabel.Location = new Point(80, 454);
            ProductTypelabel.Name = "ProductTypelabel";
            ProductTypelabel.Size = new Size(122, 21);
            ProductTypelabel.TabIndex = 11;
            ProductTypelabel.Text = "Product Type :";
            // 
            // ProductTypetextBox
            // 
            ProductTypetextBox.Anchor = AnchorStyles.None;
            ProductTypetextBox.Location = new Point(266, 451);
            ProductTypetextBox.Name = "ProductTypetextBox";
            ProductTypetextBox.Size = new Size(290, 29);
            ProductTypetextBox.TabIndex = 12;
            // 
            // ProductCategorylabel
            // 
            ProductCategorylabel.Anchor = AnchorStyles.None;
            ProductCategorylabel.AutoSize = true;
            ProductCategorylabel.Location = new Point(50, 499);
            ProductCategorylabel.Name = "ProductCategorylabel";
            ProductCategorylabel.Size = new Size(152, 21);
            ProductCategorylabel.TabIndex = 13;
            ProductCategorylabel.Text = "Product Category :";
            // 
            // ProductCategorytextBox
            // 
            ProductCategorytextBox.Anchor = AnchorStyles.None;
            ProductCategorytextBox.Location = new Point(266, 496);
            ProductCategorytextBox.Name = "ProductCategorytextBox";
            ProductCategorytextBox.Size = new Size(290, 29);
            ProductCategorytextBox.TabIndex = 14;
            // 
            // Barcodelabel
            // 
            Barcodelabel.Anchor = AnchorStyles.None;
            Barcodelabel.AutoSize = true;
            Barcodelabel.Location = new Point(120, 544);
            Barcodelabel.Name = "Barcodelabel";
            Barcodelabel.Size = new Size(82, 21);
            Barcodelabel.TabIndex = 15;
            Barcodelabel.Text = "Barcode :";
            // 
            // BarcodetextBox
            // 
            BarcodetextBox.Anchor = AnchorStyles.None;
            BarcodetextBox.Location = new Point(266, 541);
            BarcodetextBox.Name = "BarcodetextBox";
            BarcodetextBox.Size = new Size(290, 29);
            BarcodetextBox.TabIndex = 16;
            // 
            // SKUlabel
            // 
            SKUlabel.Anchor = AnchorStyles.None;
            SKUlabel.AutoSize = true;
            SKUlabel.Location = new Point(146, 589);
            SKUlabel.Name = "SKUlabel";
            SKUlabel.Size = new Size(56, 21);
            SKUlabel.TabIndex = 17;
            SKUlabel.Text = "SKU :";
            // 
            // SKUtextBox
            // 
            SKUtextBox.Anchor = AnchorStyles.None;
            SKUtextBox.Location = new Point(266, 586);
            SKUtextBox.Name = "SKUtextBox";
            SKUtextBox.Size = new Size(290, 29);
            SKUtextBox.TabIndex = 18;
            // 
            // Unitlabel
            // 
            Unitlabel.Anchor = AnchorStyles.None;
            Unitlabel.AutoSize = true;
            Unitlabel.Location = new Point(152, 634);
            Unitlabel.Name = "Unitlabel";
            Unitlabel.Size = new Size(50, 21);
            Unitlabel.TabIndex = 19;
            Unitlabel.Text = "Unit :";
            // 
            // UnittextBox
            // 
            UnittextBox.Anchor = AnchorStyles.None;
            UnittextBox.Location = new Point(266, 631);
            UnittextBox.Name = "UnittextBox";
            UnittextBox.Size = new Size(290, 29);
            UnittextBox.TabIndex = 20;
            // 
            // ExpiryDatelabel
            // 
            ExpiryDatelabel.Anchor = AnchorStyles.None;
            ExpiryDatelabel.AutoSize = true;
            ExpiryDatelabel.Location = new Point(95, 679);
            ExpiryDatelabel.Name = "ExpiryDatelabel";
            ExpiryDatelabel.Size = new Size(107, 21);
            ExpiryDatelabel.TabIndex = 21;
            ExpiryDatelabel.Text = "Expiry Date :";
            // 
            // ExpiryDatedatePicker
            // 
            ExpiryDatedatePicker.Anchor = AnchorStyles.None;
            ExpiryDatedatePicker.Format = DateTimePickerFormat.Short;
            ExpiryDatedatePicker.Location = new Point(266, 676);
            ExpiryDatedatePicker.Name = "ExpiryDatedatePicker";
            ExpiryDatedatePicker.Size = new Size(290, 29);
            ExpiryDatedatePicker.TabIndex = 22;
            // 
            // StockQuantitylabel
            // 
            StockQuantitylabel.Anchor = AnchorStyles.None;
            StockQuantitylabel.AutoSize = true;
            StockQuantitylabel.Location = new Point(71, 724);
            StockQuantitylabel.Name = "StockQuantitylabel";
            StockQuantitylabel.Size = new Size(131, 21);
            StockQuantitylabel.TabIndex = 23;
            StockQuantitylabel.Text = "Stock Quantity :";
            // 
            // StockQuantitytextBox
            // 
            StockQuantitytextBox.Anchor = AnchorStyles.None;
            StockQuantitytextBox.Location = new Point(266, 721);
            StockQuantitytextBox.Name = "StockQuantitytextBox";
            StockQuantitytextBox.Size = new Size(290, 29);
            StockQuantitytextBox.TabIndex = 24;
            // 
            // Weightlabel
            // 
            Weightlabel.Anchor = AnchorStyles.None;
            Weightlabel.AutoSize = true;
            Weightlabel.Location = new Point(692, 123);
            Weightlabel.Name = "Weightlabel";
            Weightlabel.Size = new Size(70, 21);
            Weightlabel.TabIndex = 25;
            Weightlabel.Text = "Weight :";
            // 
            // WeighttextBox
            // 
            WeighttextBox.Anchor = AnchorStyles.None;
            WeighttextBox.Location = new Point(832, 120);
            WeighttextBox.Name = "WeighttextBox";
            WeighttextBox.Size = new Size(290, 29);
            WeighttextBox.TabIndex = 26;
            // 
            // TotalSaleQuantitylabel
            // 
            TotalSaleQuantitylabel.Anchor = AnchorStyles.None;
            TotalSaleQuantitylabel.AutoSize = true;
            TotalSaleQuantitylabel.Location = new Point(601, 168);
            TotalSaleQuantitylabel.Name = "TotalSaleQuantitylabel";
            TotalSaleQuantitylabel.Size = new Size(161, 21);
            TotalSaleQuantitylabel.TabIndex = 27;
            TotalSaleQuantitylabel.Text = "Total Sale Quantity :";
            // 
            // TotalSaleQuantitytextBox
            // 
            TotalSaleQuantitytextBox.Anchor = AnchorStyles.None;
            TotalSaleQuantitytextBox.Location = new Point(832, 165);
            TotalSaleQuantitytextBox.Name = "TotalSaleQuantitytextBox";
            TotalSaleQuantitytextBox.Size = new Size(290, 29);
            TotalSaleQuantitytextBox.TabIndex = 28;
            // 
            // ReorderLevellabel
            // 
            ReorderLevellabel.Anchor = AnchorStyles.None;
            ReorderLevellabel.AutoSize = true;
            ReorderLevellabel.Location = new Point(637, 213);
            ReorderLevellabel.Name = "ReorderLevellabel";
            ReorderLevellabel.Size = new Size(125, 21);
            ReorderLevellabel.TabIndex = 29;
            ReorderLevellabel.Text = "Reorder Level :";
            // 
            // ReorderLeveltextBox
            // 
            ReorderLeveltextBox.Anchor = AnchorStyles.None;
            ReorderLeveltextBox.Location = new Point(832, 210);
            ReorderLeveltextBox.Name = "ReorderLeveltextBox";
            ReorderLeveltextBox.Size = new Size(290, 29);
            ReorderLeveltextBox.TabIndex = 30;
            // 
            // MinStockLevellabel
            // 
            MinStockLevellabel.Anchor = AnchorStyles.None;
            MinStockLevellabel.AutoSize = true;
            MinStockLevellabel.Location = new Point(620, 258);
            MinStockLevellabel.Name = "MinStockLevellabel";
            MinStockLevellabel.Size = new Size(142, 21);
            MinStockLevellabel.TabIndex = 31;
            MinStockLevellabel.Text = "Min Stock Level :";
            // 
            // MinStockLeveltextBox
            // 
            MinStockLeveltextBox.Anchor = AnchorStyles.None;
            MinStockLeveltextBox.Location = new Point(832, 255);
            MinStockLeveltextBox.Name = "MinStockLeveltextBox";
            MinStockLeveltextBox.Size = new Size(290, 29);
            MinStockLeveltextBox.TabIndex = 32;
            // 
            // IsExpirablecheckBox
            // 
            IsExpirablecheckBox.Anchor = AnchorStyles.None;
            IsExpirablecheckBox.AutoSize = true;
            IsExpirablecheckBox.Location = new Point(832, 303);
            IsExpirablecheckBox.Name = "IsExpirablecheckBox";
            IsExpirablecheckBox.Size = new Size(118, 25);
            IsExpirablecheckBox.TabIndex = 33;
            IsExpirablecheckBox.Text = "Is Expirable";
            IsExpirablecheckBox.UseVisualStyleBackColor = true;
            // 
            // SupplierIDlabel
            // 
            SupplierIDlabel.Anchor = AnchorStyles.None;
            SupplierIDlabel.AutoSize = true;
            SupplierIDlabel.Location = new Point(657, 347);
            SupplierIDlabel.Name = "SupplierIDlabel";
            SupplierIDlabel.Size = new Size(105, 21);
            SupplierIDlabel.TabIndex = 34;
            SupplierIDlabel.Text = "Supplier ID :";
            // 
            // SupplierIDtextBox
            // 
            SupplierIDtextBox.Anchor = AnchorStyles.None;
            SupplierIDtextBox.Location = new Point(832, 344);
            SupplierIDtextBox.Name = "SupplierIDtextBox";
            SupplierIDtextBox.Size = new Size(290, 29);
            SupplierIDtextBox.TabIndex = 35;
            // 
            // BuyingPricelabel
            // 
            BuyingPricelabel.Anchor = AnchorStyles.None;
            BuyingPricelabel.AutoSize = true;
            BuyingPricelabel.Location = new Point(648, 392);
            BuyingPricelabel.Name = "BuyingPricelabel";
            BuyingPricelabel.Size = new Size(114, 21);
            BuyingPricelabel.TabIndex = 36;
            BuyingPricelabel.Text = "Buying Price :";
            // 
            // BuyingPricetextBox
            // 
            BuyingPricetextBox.Anchor = AnchorStyles.None;
            BuyingPricetextBox.Location = new Point(832, 389);
            BuyingPricetextBox.Name = "BuyingPricetextBox";
            BuyingPricetextBox.Size = new Size(290, 29);
            BuyingPricetextBox.TabIndex = 37;
            // 
            // SellingPricelabel
            // 
            SellingPricelabel.Anchor = AnchorStyles.None;
            SellingPricelabel.AutoSize = true;
            SellingPricelabel.Location = new Point(651, 437);
            SellingPricelabel.Name = "SellingPricelabel";
            SellingPricelabel.Size = new Size(111, 21);
            SellingPricelabel.TabIndex = 38;
            SellingPricelabel.Text = "Selling Price :";
            // 
            // SellingPricetextBox
            // 
            SellingPricetextBox.Anchor = AnchorStyles.None;
            SellingPricetextBox.Location = new Point(832, 434);
            SellingPricetextBox.Name = "SellingPricetextBox";
            SellingPricetextBox.Size = new Size(290, 29);
            SellingPricetextBox.TabIndex = 39;
            // 
            // Discountlabel
            // 
            Discountlabel.Anchor = AnchorStyles.None;
            Discountlabel.AutoSize = true;
            Discountlabel.Location = new Point(676, 482);
            Discountlabel.Name = "Discountlabel";
            Discountlabel.Size = new Size(86, 21);
            Discountlabel.TabIndex = 40;
            Discountlabel.Text = "Discount :";
            // 
            // DiscounttextBox
            // 
            DiscounttextBox.Anchor = AnchorStyles.None;
            DiscounttextBox.Location = new Point(832, 479);
            DiscounttextBox.Name = "DiscounttextBox";
            DiscounttextBox.Size = new Size(290, 29);
            DiscounttextBox.TabIndex = 41;
            // 
            // Taxlabel
            // 
            Taxlabel.Anchor = AnchorStyles.None;
            Taxlabel.AutoSize = true;
            Taxlabel.Location = new Point(715, 527);
            Taxlabel.Name = "Taxlabel";
            Taxlabel.Size = new Size(47, 21);
            Taxlabel.TabIndex = 42;
            Taxlabel.Text = "Tax :";
            // 
            // TaxtextBox
            // 
            TaxtextBox.Anchor = AnchorStyles.None;
            TaxtextBox.Location = new Point(832, 524);
            TaxtextBox.Name = "TaxtextBox";
            TaxtextBox.Size = new Size(290, 29);
            TaxtextBox.TabIndex = 43;
            // 
            // MRPlabel
            // 
            MRPlabel.Anchor = AnchorStyles.None;
            MRPlabel.AutoSize = true;
            MRPlabel.Location = new Point(704, 572);
            MRPlabel.Name = "MRPlabel";
            MRPlabel.Size = new Size(58, 21);
            MRPlabel.TabIndex = 44;
            MRPlabel.Text = "MRP :";
            // 
            // MRPtextBox
            // 
            MRPtextBox.Anchor = AnchorStyles.None;
            MRPtextBox.Location = new Point(832, 569);
            MRPtextBox.Name = "MRPtextBox";
            MRPtextBox.Size = new Size(290, 29);
            MRPtextBox.TabIndex = 45;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(832, 617);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 46;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnablecheckBox
            // 
            ReturnablecheckBox.Anchor = AnchorStyles.None;
            ReturnablecheckBox.AutoSize = true;
            ReturnablecheckBox.Location = new Point(832, 662);
            ReturnablecheckBox.Name = "ReturnablecheckBox";
            ReturnablecheckBox.Size = new Size(109, 25);
            ReturnablecheckBox.TabIndex = 47;
            ReturnablecheckBox.Text = "Returnable";
            ReturnablecheckBox.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(692, 737);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 48;
            Savebutton.Text = "Update";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(845, 737);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 49;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(998, 737);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 50;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // UpdateProductGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1215, 799);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(ReturnablecheckBox);
            Controls.Add(IsActivecheckBox);
            Controls.Add(MRPtextBox);
            Controls.Add(MRPlabel);
            Controls.Add(TaxtextBox);
            Controls.Add(Taxlabel);
            Controls.Add(DiscounttextBox);
            Controls.Add(Discountlabel);
            Controls.Add(SellingPricetextBox);
            Controls.Add(SellingPricelabel);
            Controls.Add(BuyingPricetextBox);
            Controls.Add(BuyingPricelabel);
            Controls.Add(SupplierIDtextBox);
            Controls.Add(SupplierIDlabel);
            Controls.Add(IsExpirablecheckBox);
            Controls.Add(MinStockLeveltextBox);
            Controls.Add(MinStockLevellabel);
            Controls.Add(ReorderLeveltextBox);
            Controls.Add(ReorderLevellabel);
            Controls.Add(TotalSaleQuantitytextBox);
            Controls.Add(TotalSaleQuantitylabel);
            Controls.Add(WeighttextBox);
            Controls.Add(Weightlabel);
            Controls.Add(StockQuantitytextBox);
            Controls.Add(StockQuantitylabel);
            Controls.Add(ExpiryDatedatePicker);
            Controls.Add(ExpiryDatelabel);
            Controls.Add(UnittextBox);
            Controls.Add(Unitlabel);
            Controls.Add(SKUtextBox);
            Controls.Add(SKUlabel);
            Controls.Add(BarcodetextBox);
            Controls.Add(Barcodelabel);
            Controls.Add(ProductCategorytextBox);
            Controls.Add(ProductCategorylabel);
            Controls.Add(ProductTypetextBox);
            Controls.Add(ProductTypelabel);
            Controls.Add(BrowsePhotobutton);
            Controls.Add(PhotopictureBox);
            Controls.Add(Photolabel);
            Controls.Add(BrandtextBox);
            Controls.Add(Brandlabel);
            Controls.Add(ProductNametextBox);
            Controls.Add(ProductNamelabel);
            Controls.Add(ProductIDtextBox);
            Controls.Add(ProductIDlabel);
            Controls.Add(SearchgroupBox);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UpdateProductGUI";
            Text = "Update Product";
            WindowState = FormWindowState.Maximized;
            SearchgroupBox.ResumeLayout(false);
            SearchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox SearchgroupBox;
        private Button Searchbutton;
        private TextBox SearchtextBox;
        private Label ProductIDlabel;
        private TextBox ProductIDtextBox;
        private Label ProductNamelabel;
        private TextBox ProductNametextBox;
        private Label Brandlabel;
        private TextBox BrandtextBox;
        private Label Photolabel;
        private PictureBox PhotopictureBox;
        private Button BrowsePhotobutton;
        private Label ProductTypelabel;
        private TextBox ProductTypetextBox;
        private Label ProductCategorylabel;
        private TextBox ProductCategorytextBox;
        private Label Barcodelabel;
        private TextBox BarcodetextBox;
        private Label SKUlabel;
        private TextBox SKUtextBox;
        private Label Unitlabel;
        private TextBox UnittextBox;
        private Label ExpiryDatelabel;
        private DateTimePicker ExpiryDatedatePicker;
        private Label StockQuantitylabel;
        private TextBox StockQuantitytextBox;
        private Label Weightlabel;
        private TextBox WeighttextBox;
        private Label TotalSaleQuantitylabel;
        private TextBox TotalSaleQuantitytextBox;
        private Label ReorderLevellabel;
        private TextBox ReorderLeveltextBox;
        private Label MinStockLevellabel;
        private TextBox MinStockLeveltextBox;
        private CheckBox IsExpirablecheckBox;
        private Label SupplierIDlabel;
        private TextBox SupplierIDtextBox;
        private Label BuyingPricelabel;
        private TextBox BuyingPricetextBox;
        private Label SellingPricelabel;
        private TextBox SellingPricetextBox;
        private Label Discountlabel;
        private TextBox DiscounttextBox;
        private Label Taxlabel;
        private TextBox TaxtextBox;
        private Label MRPlabel;
        private TextBox MRPtextBox;
        private CheckBox IsActivecheckBox;
        private CheckBox ReturnablecheckBox;
        private Button Savebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
    }
}
