namespace PizzaProject
{
    partial class frmPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.btnOrderExit = new System.Windows.Forms.Button();
            this.lblPizzaOrder = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLargePizza = new System.Windows.Forms.RadioButton();
            this.rdMedPizza = new System.Windows.Forms.RadioButton();
            this.rdSmallPizza = new System.Windows.Forms.RadioButton();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.grpWhereEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereEatSummary = new System.Windows.Forms.Label();
            this.lblSizeSummary = new System.Windows.Forms.Label();
            this.lblCrustSummary = new System.Windows.Forms.Label();
            this.lblToppingsSummary = new System.Windows.Forms.Label();
            this.lblTotalPriceSummary = new System.Windows.Forms.Label();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.grpSize.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpWhereEat.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderExit
            // 
            this.btnOrderExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOrderExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderExit.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderExit.ForeColor = System.Drawing.Color.White;
            this.btnOrderExit.Location = new System.Drawing.Point(578, 417);
            this.btnOrderExit.Name = "btnOrderExit";
            this.btnOrderExit.Size = new System.Drawing.Size(67, 43);
            this.btnOrderExit.TabIndex = 0;
            this.btnOrderExit.Text = "Exit";
            this.btnOrderExit.UseVisualStyleBackColor = false;
            this.btnOrderExit.Click += new System.EventHandler(this.btnOrderExit_Click);
            // 
            // lblPizzaOrder
            // 
            this.lblPizzaOrder.AutoSize = true;
            this.lblPizzaOrder.BackColor = System.Drawing.SystemColors.Window;
            this.lblPizzaOrder.Font = new System.Drawing.Font("Tekton Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(10)))));
            this.lblPizzaOrder.Location = new System.Drawing.Point(211, 9);
            this.lblPizzaOrder.Name = "lblPizzaOrder";
            this.lblPizzaOrder.Size = new System.Drawing.Size(246, 42);
            this.lblPizzaOrder.TabIndex = 27;
            this.lblPizzaOrder.Text = "Make Your Pizza";
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpSize.Controls.Add(this.rdLargePizza);
            this.grpSize.Controls.Add(this.rdMedPizza);
            this.grpSize.Controls.Add(this.rdSmallPizza);
            this.grpSize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(12, 171);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(143, 131);
            this.grpSize.TabIndex = 21;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdLargePizza
            // 
            this.rdLargePizza.AutoSize = true;
            this.rdLargePizza.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLargePizza.Location = new System.Drawing.Point(6, 95);
            this.rdLargePizza.Name = "rdLargePizza";
            this.rdLargePizza.Size = new System.Drawing.Size(57, 19);
            this.rdLargePizza.TabIndex = 5;
            this.rdLargePizza.TabStop = true;
            this.rdLargePizza.Tag = "3";
            this.rdLargePizza.Text = "Large";
            this.rdLargePizza.UseVisualStyleBackColor = true;
            this.rdLargePizza.CheckedChanged += new System.EventHandler(this.rdLargePizza_CheckedChanged);
            // 
            // rdMedPizza
            // 
            this.rdMedPizza.AutoSize = true;
            this.rdMedPizza.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedPizza.Location = new System.Drawing.Point(6, 65);
            this.rdMedPizza.Name = "rdMedPizza";
            this.rdMedPizza.Size = new System.Drawing.Size(69, 19);
            this.rdMedPizza.TabIndex = 4;
            this.rdMedPizza.TabStop = true;
            this.rdMedPizza.Tag = "2";
            this.rdMedPizza.Text = "Meduim";
            this.rdMedPizza.UseVisualStyleBackColor = true;
            this.rdMedPizza.CheckedChanged += new System.EventHandler(this.rdMedPizza_CheckedChanged);
            // 
            // rdSmallPizza
            // 
            this.rdSmallPizza.AutoSize = true;
            this.rdSmallPizza.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmallPizza.Location = new System.Drawing.Point(6, 35);
            this.rdSmallPizza.Name = "rdSmallPizza";
            this.rdSmallPizza.Size = new System.Drawing.Size(57, 19);
            this.rdSmallPizza.TabIndex = 3;
            this.rdSmallPizza.TabStop = true;
            this.rdSmallPizza.Tag = "1";
            this.rdSmallPizza.Text = "Small";
            this.rdSmallPizza.UseVisualStyleBackColor = true;
            this.rdSmallPizza.CheckedChanged += new System.EventHandler(this.rdSmallPizza_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpCrustType.Controls.Add(this.rdThickCrust);
            this.grpCrustType.Controls.Add(this.rdThinCrust);
            this.grpCrustType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrustType.Location = new System.Drawing.Point(171, 193);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(143, 101);
            this.grpCrustType.TabIndex = 22;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThickCrust.Location = new System.Drawing.Point(6, 65);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(87, 19);
            this.rdThickCrust.TabIndex = 7;
            this.rdThickCrust.TabStop = true;
            this.rdThickCrust.Tag = "2";
            this.rdThickCrust.Text = "Thick Crust";
            this.rdThickCrust.UseVisualStyleBackColor = true;
            this.rdThickCrust.CheckedChanged += new System.EventHandler(this.rdThickCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinCrust.Location = new System.Drawing.Point(6, 35);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(82, 19);
            this.rdThinCrust.TabIndex = 6;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "1";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // grpWhereEat
            // 
            this.grpWhereEat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpWhereEat.Controls.Add(this.rdTakeOut);
            this.grpWhereEat.Controls.Add(this.rdEatIn);
            this.grpWhereEat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereEat.Location = new System.Drawing.Point(12, 86);
            this.grpWhereEat.Name = "grpWhereEat";
            this.grpWhereEat.Size = new System.Drawing.Size(188, 79);
            this.grpWhereEat.TabIndex = 20;
            this.grpWhereEat.TabStop = false;
            this.grpWhereEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOut.Location = new System.Drawing.Point(93, 34);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(71, 19);
            this.rdTakeOut.TabIndex = 2;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Tag = "4";
            this.rdTakeOut.Text = "Take out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatIn.Location = new System.Drawing.Point(6, 34);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(56, 19);
            this.rdEatIn.TabIndex = 1;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Tag = "6";
            this.rdEatIn.Text = "Eat in";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpToppings.Controls.Add(this.chkGreenPepper);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraChees);
            this.grpToppings.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(96, 317);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(309, 142);
            this.grpToppings.TabIndex = 23;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(138, 97);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(118, 21);
            this.chkGreenPepper.TabIndex = 13;
            this.chkGreenPepper.Tag = "1";
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(138, 66);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(68, 21);
            this.chkOlives.TabIndex = 12;
            this.chkOlives.Tag = "1";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(138, 35);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(66, 21);
            this.chkOnion.TabIndex = 11;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(9, 97);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 21);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(9, 66);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(104, 21);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Tag = "1";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(9, 35);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(108, 21);
            this.chkExtraChees.TabIndex = 8;
            this.chkExtraChees.Tag = "1";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.White;
            this.btnOrderPizza.Location = new System.Drawing.Point(417, 417);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(75, 43);
            this.btnOrderPizza.TabIndex = 24;
            this.btnOrderPizza.Text = "Order";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrder.Font = new System.Drawing.Font("Cooper Std Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.ForeColor = System.Drawing.Color.White;
            this.btnResetOrder.Location = new System.Drawing.Point(497, 417);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(75, 43);
            this.btnResetOrder.TabIndex = 25;
            this.btnResetOrder.Text = "Reset";
            this.btnResetOrder.UseVisualStyleBackColor = false;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWhereToEat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(16, 33);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(102, 18);
            this.lblWhereToEat.TabIndex = 29;
            this.lblWhereToEat.Text = "Where to eat:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(16, 61);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 18);
            this.lblSize.TabIndex = 30;
            this.lblSize.Text = "Size:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCrustType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(16, 92);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(85, 18);
            this.lblCrustType.TabIndex = 31;
            this.lblCrustType.Text = "Crust type:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToppings.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(16, 123);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(78, 18);
            this.lblToppings.TabIndex = 32;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(428, 352);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(88, 18);
            this.lblTotalPrice.TabIndex = 33;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblWhereEatSummary
            // 
            this.lblWhereEatSummary.AutoSize = true;
            this.lblWhereEatSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWhereEatSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereEatSummary.Location = new System.Drawing.Point(118, 34);
            this.lblWhereEatSummary.Name = "lblWhereEatSummary";
            this.lblWhereEatSummary.Size = new System.Drawing.Size(37, 16);
            this.lblWhereEatSummary.TabIndex = 34;
            this.lblWhereEatSummary.Text = "None";
            // 
            // lblSizeSummary
            // 
            this.lblSizeSummary.AutoSize = true;
            this.lblSizeSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSizeSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeSummary.Location = new System.Drawing.Point(118, 63);
            this.lblSizeSummary.Name = "lblSizeSummary";
            this.lblSizeSummary.Size = new System.Drawing.Size(37, 16);
            this.lblSizeSummary.TabIndex = 35;
            this.lblSizeSummary.Text = "None";
            // 
            // lblCrustSummary
            // 
            this.lblCrustSummary.AutoSize = true;
            this.lblCrustSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCrustSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustSummary.Location = new System.Drawing.Point(118, 94);
            this.lblCrustSummary.Name = "lblCrustSummary";
            this.lblCrustSummary.Size = new System.Drawing.Size(37, 16);
            this.lblCrustSummary.TabIndex = 36;
            this.lblCrustSummary.Text = "None";
            // 
            // lblToppingsSummary
            // 
            this.lblToppingsSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToppingsSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsSummary.Location = new System.Drawing.Point(117, 124);
            this.lblToppingsSummary.Name = "lblToppingsSummary";
            this.lblToppingsSummary.Size = new System.Drawing.Size(228, 64);
            this.lblToppingsSummary.TabIndex = 37;
            this.lblToppingsSummary.Text = "None";
            // 
            // lblTotalPriceSummary
            // 
            this.lblTotalPriceSummary.AutoSize = true;
            this.lblTotalPriceSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPriceSummary.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceSummary.Location = new System.Drawing.Point(543, 345);
            this.lblTotalPriceSummary.Name = "lblTotalPriceSummary";
            this.lblTotalPriceSummary.Size = new System.Drawing.Size(29, 32);
            this.lblTotalPriceSummary.TabIndex = 39;
            this.lblTotalPriceSummary.Tag = "";
            this.lblTotalPriceSummary.Text = "0";
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpOrderSummary.Controls.Add(this.lblToppingsSummary);
            this.grpOrderSummary.Controls.Add(this.lblCrustSummary);
            this.grpOrderSummary.Controls.Add(this.lblSizeSummary);
            this.grpOrderSummary.Controls.Add(this.lblWhereEatSummary);
            this.grpOrderSummary.Controls.Add(this.lblToppings);
            this.grpOrderSummary.Controls.Add(this.lblCrustType);
            this.grpOrderSummary.Controls.Add(this.lblSize);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEat);
            this.grpOrderSummary.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.Location = new System.Drawing.Point(346, 114);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(351, 207);
            this.grpOrderSummary.TabIndex = 28;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject.Properties.Resources.SecondForm;
            this.ClientSize = new System.Drawing.Size(709, 471);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.lblTotalPriceSummary);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpWhereEat);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.lblPizzaOrder);
            this.Controls.Add(this.btnOrderExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpWhereEat.ResumeLayout(false);
            this.grpWhereEat.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderExit;
        private System.Windows.Forms.Label lblPizzaOrder;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdMedPizza;
        private System.Windows.Forms.RadioButton rdSmallPizza;
        private System.Windows.Forms.RadioButton rdLargePizza;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox grpWhereEat;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblWhereEatSummary;
        private System.Windows.Forms.Label lblSizeSummary;
        private System.Windows.Forms.Label lblCrustSummary;
        private System.Windows.Forms.Label lblToppingsSummary;
        private System.Windows.Forms.Label lblTotalPriceSummary;
        private System.Windows.Forms.GroupBox grpOrderSummary;
    }
}