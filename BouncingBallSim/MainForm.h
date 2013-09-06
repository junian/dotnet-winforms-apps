#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing; 
using namespace System::Drawing::Drawing2D;

namespace BakaDevBouncingBall {

	/// <summary>
	/// Summary for MainForm
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary> 
	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			t = 0.05f;
			bouncingBalls = gcnew BouncingBalls((float) pnlBallWorld->Width, (float) pnlBallWorld->Height);
			cmbColor->BeginUpdate();
			cmbColor->Items->Add(Color::Blue);
			cmbColor->Items->Add(Color::Green);
			cmbColor->Items->Add(Color::Gold);
			cmbColor->Items->Add(Color::Brown);
			cmbColor->Items->Add(Color::Crimson);
			cmbColor->Items->Add(Color::HotPink);
			cmbColor->Items->Add(Color::DarkCyan);
			cmbColor->Items->Add(Color::Violet);
			cmbColor->Items->Add(Color::CornflowerBlue);
			cmbColor->Items->Add(Color::Orange);
			cmbColor->Items->Add(Color::Olive);
			cmbColor->EndUpdate();
			cmbColor->SelectedItem = cmbColor->Items[0];
			radioMini->Checked = true;
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: BakaDevBouncingBall::DoubleBufferedPanel^  pnlBallWorld;
	private: System::Windows::Forms::GroupBox^  grpControlCenter;
	private: System::Windows::Forms::ComboBox^  cmbColor;

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::NumericUpDown^  numericUpDown;

	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Button^  btnSummon;
	private: System::Windows::Forms::RadioButton^  radioMega;

	private: System::Windows::Forms::RadioButton^  radioMedium;

	private: System::Windows::Forms::RadioButton^  radioMini;

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Button^  btnDestroy;

	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::CheckedListBox^  chkMode;
	private: System::Windows::Forms::Timer^  tmrAction;
	private: System::ComponentModel::IContainer^  components;



	protected: 

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		BouncingBalls^ bouncingBalls;
		float t;
	private: System::Windows::Forms::Label^  lblTotal;
	private: System::Windows::Forms::Button^  btnExit;

	private: System::Windows::Forms::Button^  btnAbout;

			 static Random^ rand = gcnew Random();

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(MainForm::typeid));
			this->grpControlCenter = (gcnew System::Windows::Forms::GroupBox());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->btnAbout = (gcnew System::Windows::Forms::Button());
			this->lblTotal = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->chkMode = (gcnew System::Windows::Forms::CheckedListBox());
			this->radioMega = (gcnew System::Windows::Forms::RadioButton());
			this->radioMedium = (gcnew System::Windows::Forms::RadioButton());
			this->radioMini = (gcnew System::Windows::Forms::RadioButton());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->btnDestroy = (gcnew System::Windows::Forms::Button());
			this->btnSummon = (gcnew System::Windows::Forms::Button());
			this->numericUpDown = (gcnew System::Windows::Forms::NumericUpDown());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->cmbColor = (gcnew System::Windows::Forms::ComboBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->tmrAction = (gcnew System::Windows::Forms::Timer(this->components));
			this->pnlBallWorld = (gcnew BakaDevBouncingBall::DoubleBufferedPanel());
			this->grpControlCenter->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown))->BeginInit();
			this->SuspendLayout();
			// 
			// grpControlCenter
			// 
			this->grpControlCenter->Controls->Add(this->btnExit);
			this->grpControlCenter->Controls->Add(this->btnAbout);
			this->grpControlCenter->Controls->Add(this->lblTotal);
			this->grpControlCenter->Controls->Add(this->label4);
			this->grpControlCenter->Controls->Add(this->chkMode);
			this->grpControlCenter->Controls->Add(this->radioMega);
			this->grpControlCenter->Controls->Add(this->radioMedium);
			this->grpControlCenter->Controls->Add(this->radioMini);
			this->grpControlCenter->Controls->Add(this->label3);
			this->grpControlCenter->Controls->Add(this->btnDestroy);
			this->grpControlCenter->Controls->Add(this->btnSummon);
			this->grpControlCenter->Controls->Add(this->numericUpDown);
			this->grpControlCenter->Controls->Add(this->label2);
			this->grpControlCenter->Controls->Add(this->cmbColor);
			this->grpControlCenter->Controls->Add(this->label1);
			this->grpControlCenter->Location = System::Drawing::Point(9, 12);
			this->grpControlCenter->Name = L"grpControlCenter";
			this->grpControlCenter->Size = System::Drawing::Size(148, 453);
			this->grpControlCenter->TabIndex = 1;
			this->grpControlCenter->TabStop = false;
			this->grpControlCenter->Text = L"Control Center";
			// 
			// btnExit
			// 
			this->btnExit->Location = System::Drawing::Point(9, 420);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(133, 23);
			this->btnExit->TabIndex = 14;
			this->btnExit->Text = L"E&xit";
			this->btnExit->UseVisualStyleBackColor = true;
			this->btnExit->Click += gcnew System::EventHandler(this, &MainForm::btnExit_Click);
			// 
			// btnAbout
			// 
			this->btnAbout->Location = System::Drawing::Point(9, 391);
			this->btnAbout->Name = L"btnAbout";
			this->btnAbout->Size = System::Drawing::Size(133, 23);
			this->btnAbout->TabIndex = 13;
			this->btnAbout->Text = L"&About";
			this->btnAbout->UseVisualStyleBackColor = true;
			this->btnAbout->Click += gcnew System::EventHandler(this, &MainForm::btnAbout_Click);
			// 
			// lblTotal
			// 
			this->lblTotal->AutoSize = true;
			this->lblTotal->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->lblTotal->Location = System::Drawing::Point(11, 358);
			this->lblTotal->Name = L"lblTotal";
			this->lblTotal->Size = System::Drawing::Size(60, 24);
			this->lblTotal->TabIndex = 12;
			this->lblTotal->Text = L"label5";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(6, 272);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(37, 13);
			this->label4->TabIndex = 11;
			this->label4->Text = L"&Mode:";
			// 
			// chkMode
			// 
			this->chkMode->CheckOnClick = true;
			this->chkMode->FormattingEnabled = true;
			this->chkMode->Items->AddRange(gcnew cli::array< System::Object^  >(4) {L"Ball to Ball Collision", L"Pause", L"Reverse Gravity", 
				L"Slow Motion"});
			this->chkMode->Location = System::Drawing::Point(7, 288);
			this->chkMode->Name = L"chkMode";
			this->chkMode->Size = System::Drawing::Size(133, 64);
			this->chkMode->TabIndex = 10;
			this->chkMode->ItemCheck += gcnew System::Windows::Forms::ItemCheckEventHandler(this, &MainForm::chkMode_ItemCheck);
			// 
			// radioMega
			// 
			this->radioMega->AutoSize = true;
			this->radioMega->Location = System::Drawing::Point(9, 134);
			this->radioMega->Name = L"radioMega";
			this->radioMega->Size = System::Drawing::Size(52, 17);
			this->radioMega->TabIndex = 9;
			this->radioMega->TabStop = true;
			this->radioMega->Text = L"Mega";
			this->radioMega->UseVisualStyleBackColor = true;
			// 
			// radioMedium
			// 
			this->radioMedium->AutoSize = true;
			this->radioMedium->Location = System::Drawing::Point(9, 111);
			this->radioMedium->Name = L"radioMedium";
			this->radioMedium->Size = System::Drawing::Size(62, 17);
			this->radioMedium->TabIndex = 8;
			this->radioMedium->TabStop = true;
			this->radioMedium->Text = L"Medium";
			this->radioMedium->UseVisualStyleBackColor = true;
			// 
			// radioMini
			// 
			this->radioMini->AutoSize = true;
			this->radioMini->Location = System::Drawing::Point(9, 88);
			this->radioMini->Name = L"radioMini";
			this->radioMini->Size = System::Drawing::Size(44, 17);
			this->radioMini->TabIndex = 7;
			this->radioMini->TabStop = true;
			this->radioMini->Text = L"Mini";
			this->radioMini->UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(6, 165);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(49, 13);
			this->label3->TabIndex = 6;
			this->label3->Text = L"&Quantity:";
			// 
			// btnDestroy
			// 
			this->btnDestroy->Location = System::Drawing::Point(9, 240);
			this->btnDestroy->Name = L"btnDestroy";
			this->btnDestroy->Size = System::Drawing::Size(133, 23);
			this->btnDestroy->TabIndex = 5;
			this->btnDestroy->Text = L"&Destroy All";
			this->btnDestroy->UseVisualStyleBackColor = true;
			this->btnDestroy->Click += gcnew System::EventHandler(this, &MainForm::btnDestroy_Click);
			// 
			// btnSummon
			// 
			this->btnSummon->Location = System::Drawing::Point(9, 211);
			this->btnSummon->Name = L"btnSummon";
			this->btnSummon->Size = System::Drawing::Size(133, 23);
			this->btnSummon->TabIndex = 4;
			this->btnSummon->Text = L"&Summon Ball(s)";
			this->btnSummon->UseVisualStyleBackColor = true;
			this->btnSummon->Click += gcnew System::EventHandler(this, &MainForm::btnSummon_Click);
			// 
			// numericUpDown
			// 
			this->numericUpDown->Location = System::Drawing::Point(9, 181);
			this->numericUpDown->Minimum = System::Decimal(gcnew cli::array< System::Int32 >(4) {1, 0, 0, 0});
			this->numericUpDown->Name = L"numericUpDown";
			this->numericUpDown->Size = System::Drawing::Size(133, 20);
			this->numericUpDown->TabIndex = 3;
			this->numericUpDown->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) {1, 0, 0, 0});
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(6, 72);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(27, 13);
			this->label2->TabIndex = 2;
			this->label2->Text = L"S&ize";
			// 
			// cmbColor
			// 
			this->cmbColor->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->cmbColor->FormattingEnabled = true;
			this->cmbColor->Location = System::Drawing::Point(6, 39);
			this->cmbColor->Name = L"cmbColor";
			this->cmbColor->Size = System::Drawing::Size(136, 21);
			this->cmbColor->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(6, 23);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(34, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"&Color:";
			// 
			// tmrAction
			// 
			this->tmrAction->Enabled = true;
			this->tmrAction->Interval = 25;
			this->tmrAction->Tick += gcnew System::EventHandler(this, &MainForm::tmrAction_Tick);
			// 
			// pnlBallWorld
			// 
			this->pnlBallWorld->BackColor = System::Drawing::Color::Black;
			this->pnlBallWorld->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->pnlBallWorld->Location = System::Drawing::Point(163, 12);
			this->pnlBallWorld->Name = L"pnlBallWorld";
			this->pnlBallWorld->Size = System::Drawing::Size(622, 453);
			this->pnlBallWorld->TabIndex = 0;
			this->pnlBallWorld->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &MainForm::pnlBallWorld_Paint);
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Control;
			this->ClientSize = System::Drawing::Size(797, 477);
			this->Controls->Add(this->grpControlCenter);
			this->Controls->Add(this->pnlBallWorld);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->Name = L"MainForm";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"BakaDev Crazy Bouncing Ball";
			this->FormClosing += gcnew System::Windows::Forms::FormClosingEventHandler(this, &MainForm::MainForm_FormClosing);
			this->grpControlCenter->ResumeLayout(false);
			this->grpControlCenter->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	
	private: System::Void pnlBallWorld_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) 
			 {
				 Graphics ^g = e->Graphics;
				 g->SmoothingMode = SmoothingMode::HighQuality;
				 g->CompositingQuality = CompositingQuality::HighQuality;

				 pnlBallWorld->SuspendLayout();
				 bouncingBalls->DrawBalls(g);
				 pnlBallWorld->ResumeLayout();
			 }

	private: System::Void MainForm_FormClosing(System::Object^  sender, System::Windows::Forms::FormClosingEventArgs^  e) 
			 {
				if(MessageBox::Show(
					 "What? Do You want to quit?",
					 this->Text, 
					 MessageBoxButtons::YesNo, 
					 MessageBoxIcon::Question, 
					 MessageBoxDefaultButton::Button2) == System::Windows::Forms::DialogResult::No)
					 e->Cancel = true;
			 }

	private: System::Void btnSummon_Click(System::Object^  sender, System::EventArgs^  e) 
			 {
				 float size = 0.0f;
				 if(radioMini->Checked)
					 size = 10.0f;
				 else if(radioMedium->Checked)
					 size = 20.0f;
				 else if(radioMega->Checked)
					 size = 30.0f;
				 for(int i=0; i<(int)numericUpDown->Value; i++)
				 {
					 if(bouncingBalls->Area >= 0.9f * pnlBallWorld->Width * pnlBallWorld->Height)
					 {
						 MessageBox::Show("The World of Ball is full!\nYou can't summon any ball",
							 this->Text);
						 return;
					 }
					 bouncingBalls->Add(gcnew Ball(
						 (float) rand->Next(pnlBallWorld->Width - (int)(2*size)),
						 (float) rand->Next(0, (pnlBallWorld->Height - (int)(2*size))/2),
						 size,
						 rand->Next(2) == 0 ? (float) -rand->Next(1, 10) : (float) rand->Next(1, 10),
						 (float) rand->Next(0, 10),
						 (Color) cmbColor->SelectedItem));
				 }
			 }

	private: System::Void tmrAction_Tick(System::Object^  sender, System::EventArgs^  e) 
			 {
				 lblTotal->Text = "Total: " + bouncingBalls->Count.ToString();
				 bouncingBalls->MoveBalls(t);
				 if(chkMode->GetItemChecked(0))
					 bouncingBalls->BallToBallCollision(t);
				 bouncingBalls->BallToWallCollision(t);
				 pnlBallWorld->Refresh();
			 }

	private: System::Void btnDestroy_Click(System::Object^  sender, System::EventArgs^  e) 
			 {
				 bouncingBalls->DestroyAll();
			 }

	private: System::Void chkMode_ItemCheck(System::Object^  sender, System::Windows::Forms::ItemCheckEventArgs^  e) 
			 {
				 switch(e->Index)
				 {
				 case 1:
					 tmrAction->Enabled = !tmrAction->Enabled;
					 btnDestroy->Enabled = !btnDestroy->Enabled;
					 btnSummon->Enabled = !btnSummon->Enabled;
					 break;
				 case 2:
					 BouncingBalls::Gravity *= -1;
					 break;
				 case 3:
					 if(!chkMode->GetItemChecked(3))
					 {
						 tmrAction->Interval = 50;
					 }
					 else if(chkMode->GetItemChecked(3))
					 {
						 tmrAction->Interval = 25;
					 }
					 break;
				 default:
					 break;
				 }
			 }

	private: System::Void btnExit_Click(System::Object^  sender, System::EventArgs^  e)
			 {
				 this->Close();
			 }
	private: System::Void btnAbout_Click(System::Object^  sender, System::EventArgs^  e) {
				 (gcnew BakaDevBouncingBall::About())->Show(this);
			 }
};
}

