<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurrency
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(59, 661)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "계산"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(59, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(661, 43)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 326
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Items.AddRange(New Object() {"United Arab Emirates Dirham (AED)", "Afghan Afghani (AFN) ", "Albanian Lek (ALL)", "Armenian Dram (AMD)", "Netherlands Antillean Guilder (ANG)", "Angolan Kwanza (AOA)", "Argentine Peso (ARS)", "Australian Dollar (A$)", "Aruban Florin (AWG)", "Azerbaijani Manat (AZN)", "Bosnia - Herzegovina Convertible Mark (BAM)", "Barbadian Dollar (BBD)", "Bangladeshi Taka (BDT)", "Bulgarian Lev (BGN)", "Bahraini Dinar (BHD)", "Burundian Franc (BIF)", "Bermudan Dollar (BMD)", "Brunei Dollar (BND)", "Bolivian Boliviano (BOB)", "Brazilian Real (R$)", "Bahamian Dollar (BSD)", "Bitcoin(฿)", "Bhutanese Ngultrum(BTN)", "Botswanan Pula(BWP)", "Belarusian Ruble(BYN)", "Belarusian Ruble(2000–2016) (BYR)", "Belize Dollar (BZD)", "Canadian Dollar (CA$)", "Congolese Franc (CDF)", "Swiss Franc (CHF)", "Chilean Unit Of Account (UF) (CLF)", "Chilean Peso (CLP)", "CNH (CNH)", "Chinese Yuan (CN¥)", "Colombian Peso (COP)", "Costa Rican Colón (CRC)", "Cuban Peso (CUP)", "Cape Verdean Escudo (CVE)", "Czech Republic Koruna (CZK)", "German Mark (DEM)", "Djiboutian Franc (DJF)", "Danish Krone (DKK)", "Dominican Peso (DOP)", "Algerian Dinar (DZD)", "Egyptian Pound (EGP)", "Eritrean Nakfa (ERN)", "Ethiopian Birr (ETB)", "Euro (€)", "Finnish Markka (FIM)", "Fijian Dollar (FJD)", "Falkland Islands Pound (FKP)", "French Franc (FRF)", "British Pound (£)", "Georgian Lari (GEL)", "Ghanaian Cedi (GHS)", "Gibraltar Pound (GIP)", "Gambian Dalasi (GMD)", "Guinean Franc (GNF)", "Guatemalan Quetzal (GTQ)", "Guyanaese Dollar (GYD)", "Hong Kong Dollar (HK$)", "Honduran Lempira (HNL)", "Croatian Kuna (HRK)", "Haitian Gourde (HTG)", "Hungarian Forint (HUF)", "Indonesian Rupiah (IDR)", "Irish Pound (IEP)", "Israeli New Shekel (₪)", "Indian Rupee (₹)", "Iraqi Dinar (IQD)", "Iranian Rial (IRR)", "Icelandic Króna (ISK)", "Italian Lira (ITL)", "Jamaican Dollar (JMD)", "Jordanian Dinar (JOD)", "Japanese Yen (¥)", "Kenyan Shilling (KES)", "Kyrgystani Som (KGS)", "Cambodian Riel (KHR)", "Comorian Franc (KMF)", "North Korean Won (KPW)", "South Korean Won (₩)", "Kuwaiti Dinar (KWD)", "Cayman Islands Dollar (KYD)", "Kazakhstani Tenge(KZT)", "Laotian Kip (LAK)", "Lebanese Pound (LBP)", "Sri Lankan Rupee (LKR)", "Liberian Dollar (LRD)", "Lesotho Loti (LSL)", "Lithuanian Litas (LTL)", "Latvian Lats (LVL)", "Libyan Dinar (LYD) ", "Moroccan Dirham (MAD)", "Moldovan Leu (MDL)", "Malagasy Ariary (MGA)", "Macedonian Denar (MKD)", "Myanmar Kyat (MMK)", "Mongolian Tugrik (MNT)", "Macanese Pataca (MOP)", "Mauritanian Ouguiya (MRO)", "Mauritian Rupee (MUR)", "Maldivian Rufiyaa (MVR)", "Malawian Kwacha (MWK)", "Mexican Peso (MX$)", "Malaysian Ringgit (MYR)", "Mozambican Metical (MZN)", "Namibian Dollar (NAD)", "Nigerian Naira (NGN)", "Nicaraguan Córdoba (NIO)", "Norwegian Krone (NOK)", "Nepalese Rupee (NPR)", "New Zealand Dollar (NZ$)", "Omani Rial (OMR)", "Panamanian Balboa (PAB)", "Peruvian Sol (Pen)", "Papua New Guinean Kina (PGK)", "Philippine Peso(PHP)", "PKG (PKG)", "Pakistani Rupee (PKR)", "Polish Zloty (PLN)", "Paraguayan Guarani (PYG)", "Qatari Rial (QAR)", "Romanian Leu (RON)", "Serbian Dinar (RSD)", "Russian Ruble (RUB)", "Rwandan Franc (RWF)", "Saudi Riyal (SAR)", "Solomon Islands Dollar (SBD)", "Seychellois Rupee (SCR)", "Sudanese Pound (SDG)", "Swedish Krona (SEK)", "Singapore Dollar (SGD)", "St. Helena Pound (SHP)", "Slovak Koruna (SKK)", "Sierra Leonean Leone (SLL)", "Somali Shilling (SOS)", "Surinamese Dollar (SRD)", "São Tomé & Príncipe Dobra (STD)", "Salvadoran Colón (SVC)", "Syrian Pound (SYP)", "Swazi Lilangeni (SZL)", "Thai Baht (THB)", "Tajikistani Somoni(TJS)", "Turkmenistani Manat(TMT)", "Tunisian Dinar (TND)", "Tongan Paʻanga (TOP)", "Turkish Lira (Try)", "Trinidad & Tobago Dollar (TTD)", "New Taiwan Dollar (NT$)", "Tanzanian Shilling (TZS)", "Ukrainian Hryvnia (UAH)", "Ugandan Shilling (UGX)", "US Dollar ($)", "Uruguayan Peso (UYU)", "Uzbekistani Som (UZS)", "Venezuelan Bolívar (VEF)", "Vietnamese Dong (₫)", "Vanuatu Vatu (VUV)", "Samoan Tala (WST)", "Central African CFA Franc (FCFA)", "East Caribbean Dollar (EC$)", "Special Drawing Rights (XDR)", "West African CFA Franc (CFA)", "CFP Franc (CFPF)", "Yemeni Rial (YER)", "South African Rand (ZAR)", "Zambian Kwacha (1968–2012) (ZMK)", "Zambian Kwacha (ZMW)", "Zimbabwean Dollar (2009) (ZWL)"})
        Me.ComboBox1.Location = New System.Drawing.Point(59, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(661, 44)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownHeight = 326
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.Items.AddRange(New Object() {"United Arab Emirates Dirham (AED)", "Afghan Afghani (AFN) ", "Albanian Lek (ALL)", "Armenian Dram (AMD)", "Netherlands Antillean Guilder (ANG)", "Angolan Kwanza (AOA)", "Argentine Peso (ARS)", "Australian Dollar (A$)", "Aruban Florin (AWG)", "Azerbaijani Manat (AZN)", "Bosnia - Herzegovina Convertible Mark (BAM)", "Barbadian Dollar (BBD)", "Bangladeshi Taka (BDT)", "Bulgarian Lev (BGN)", "Bahraini Dinar (BHD)", "Burundian Franc (BIF)", "Bermudan Dollar (BMD)", "Brunei Dollar (BND)", "Bolivian Boliviano (BOB)", "Brazilian Real (R$)", "Bahamian Dollar (BSD)", "Bitcoin(฿)", "Bhutanese Ngultrum(BTN)", "Botswanan Pula(BWP)", "Belarusian Ruble(BYN)", "Belarusian Ruble(2000–2016) (BYR)", "Belize Dollar (BZD)", "Canadian Dollar (CA$)", "Congolese Franc (CDF)", "Swiss Franc (CHF)", "Chilean Unit Of Account (UF) (CLF)", "Chilean Peso (CLP)", "CNH (CNH)", "Chinese Yuan (CN¥)", "Colombian Peso (COP)", "Costa Rican Colón (CRC)", "Cuban Peso (CUP)", "Cape Verdean Escudo (CVE)", "Czech Republic Koruna (CZK)", "German Mark (DEM)", "Djiboutian Franc (DJF)", "Danish Krone (DKK)", "Dominican Peso (DOP)", "Algerian Dinar (DZD)", "Egyptian Pound (EGP)", "Eritrean Nakfa (ERN)", "Ethiopian Birr (ETB)", "Euro (€)", "Finnish Markka (FIM)", "Fijian Dollar (FJD)", "Falkland Islands Pound (FKP)", "French Franc (FRF)", "British Pound (£)", "Georgian Lari (GEL)", "Ghanaian Cedi (GHS)", "Gibraltar Pound (GIP)", "Gambian Dalasi (GMD)", "Guinean Franc (GNF)", "Guatemalan Quetzal (GTQ)", "Guyanaese Dollar (GYD)", "Hong Kong Dollar (HK$)", "Honduran Lempira (HNL)", "Croatian Kuna (HRK)", "Haitian Gourde (HTG)", "Hungarian Forint (HUF)", "Indonesian Rupiah (IDR)", "Irish Pound (IEP)", "Israeli New Shekel (₪)", "Indian Rupee (₹)", "Iraqi Dinar (IQD)", "Iranian Rial (IRR)", "Icelandic Króna (ISK)", "Italian Lira (ITL)", "Jamaican Dollar (JMD)", "Jordanian Dinar (JOD)", "Japanese Yen (¥)", "Kenyan Shilling (KES)", "Kyrgystani Som (KGS)", "Cambodian Riel (KHR)", "Comorian Franc (KMF)", "North Korean Won (KPW)", "South Korean Won (₩)", "Kuwaiti Dinar (KWD)", "Cayman Islands Dollar (KYD)", "Kazakhstani Tenge(KZT)", "Laotian Kip (LAK)", "Lebanese Pound (LBP)", "Sri Lankan Rupee (LKR)", "Liberian Dollar (LRD)", "Lesotho Loti (LSL)", "Lithuanian Litas (LTL)", "Latvian Lats (LVL)", "Libyan Dinar (LYD) ", "Moroccan Dirham (MAD)", "Moldovan Leu (MDL)", "Malagasy Ariary (MGA)", "Macedonian Denar (MKD)", "Myanmar Kyat (MMK)", "Mongolian Tugrik (MNT)", "Macanese Pataca (MOP)", "Mauritanian Ouguiya (MRO)", "Mauritian Rupee (MUR)", "Maldivian Rufiyaa (MVR)", "Malawian Kwacha (MWK)", "Mexican Peso (MX$)", "Malaysian Ringgit (MYR)", "Mozambican Metical (MZN)", "Namibian Dollar (NAD)", "Nigerian Naira (NGN)", "Nicaraguan Córdoba (NIO)", "Norwegian Krone (NOK)", "Nepalese Rupee (NPR)", "New Zealand Dollar (NZ$)", "Omani Rial (OMR)", "Panamanian Balboa (PAB)", "Peruvian Sol (Pen)", "Papua New Guinean Kina (PGK)", "Philippine Peso(PHP)", "PKG (PKG)", "Pakistani Rupee (PKR)", "Polish Zloty (PLN)", "Paraguayan Guarani (PYG)", "Qatari Rial (QAR)", "Romanian Leu (RON)", "Serbian Dinar (RSD)", "Russian Ruble (RUB)", "Rwandan Franc (RWF)", "Saudi Riyal (SAR)", "Solomon Islands Dollar (SBD)", "Seychellois Rupee (SCR)", "Sudanese Pound (SDG)", "Swedish Krona (SEK)", "Singapore Dollar (SGD)", "St. Helena Pound (SHP)", "Slovak Koruna (SKK)", "Sierra Leonean Leone (SLL)", "Somali Shilling (SOS)", "Surinamese Dollar (SRD)", "São Tomé & Príncipe Dobra (STD)", "Salvadoran Colón (SVC)", "Syrian Pound (SYP)", "Swazi Lilangeni (SZL)", "Thai Baht (THB)", "Tajikistani Somoni(TJS)", "Turkmenistani Manat(TMT)", "Tunisian Dinar (TND)", "Tongan Paʻanga (TOP)", "Turkish Lira (Try)", "Trinidad & Tobago Dollar (TTD)", "New Taiwan Dollar (NT$)", "Tanzanian Shilling (TZS)", "Ukrainian Hryvnia (UAH)", "Ugandan Shilling (UGX)", "US Dollar ($)", "Uruguayan Peso (UYU)", "Uzbekistani Som (UZS)", "Venezuelan Bolívar (VEF)", "Vietnamese Dong (₫)", "Vanuatu Vatu (VUV)", "Samoan Tala (WST)", "Central African CFA Franc (FCFA)", "East Caribbean Dollar (EC$)", "Special Drawing Rights (XDR)", "West African CFA Franc (CFA)", "CFP Franc (CFPF)", "Yemeni Rial (YER)", "South African Rand (ZAR)", "Zambian Kwacha (1968–2012) (ZMK)", "Zambian Kwacha (ZMW)", "Zimbabwean Dollar (2009) (ZWL)"})
        Me.ComboBox2.Location = New System.Drawing.Point(59, 367)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(661, 44)
        Me.ComboBox2.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 817)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(3, 0, 28, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(839, 47)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(300, 42)
        Me.ToolStripStatusLabel2.Text = "1 AUD = 858.44 KRW"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(387, 42)
        Me.ToolStripStatusLabel1.Text = "최종 업데이트 : 12/30/2017 12:54 PM"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.Gold
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.IsLink = True
        Me.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(150, 42)
        Me.ToolStripStatusLabel3.Text = "환율 업데이트"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(50, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 49)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "0.00"
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel.ForeColor = System.Drawing.Color.Gray
        Me.ResultsLabel.Location = New System.Drawing.Point(53, 261)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(173, 36)
        Me.ResultsLabel.TabIndex = 21
        Me.ResultsLabel.Text = "환율 계산 결과"
        '
        'FrmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 864)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCurrency"
        Me.Text = "환율쟁이"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
End Class
