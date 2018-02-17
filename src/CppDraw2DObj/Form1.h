#pragma once


namespace CppDraw2DObj {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^  panel1;
	protected: 

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->SuspendLayout();
			// 
			// panel1
			// 
			this->panel1->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->panel1->Location = System::Drawing::Point(12, 126);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(268, 128);
			this->panel1->TabIndex = 0;
			this->panel1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Form1::panel1_Paint);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(292, 266);
			this->Controls->Add(this->panel1);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Form1::Form1_Paint);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Form1_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
				 Graphics^ g = e->Graphics;
				 
				 //make the image become High Quality
				 g->SmoothingMode = Drawing2D::SmoothingMode::HighQuality;

				 //fill an ellipse with
				 //  White color
				 //  start position = (10, 10) (start position is always Top Left of the object)
				 //  width = 75 px, height = 50 px
				 g->FillEllipse(Brushes::White, 10, 10, 75, 50);

				 //create an ellipse with
				 //  Black color
				 //  start position = (10, 10) (start position is always Top Left of the object)
				 //  width = 75 px, height = 50 px
				 g->DrawEllipse(Pens::Black, 10, 10, 75, 50);

				 //fill a circle with
				 //  Yellow color
				 //  start position = (90, 10)
				 //  diameter = 75 px
				 g->FillEllipse(Brushes::Yellow, 90, 10, 75, 75);

				 //create an ellipse with
				 //  Red color
				 //  start postion = (90, 10)
				 //  width = 75 px, height = 75 px
				 //or you can say create a circle with
				 //  Red color
				 //  start position = (90, 10)
				 //  diameter = 75 px
				 g->DrawEllipse(Pens::Red, 90, 10, 75, 75);
				
				 //fill a rectangle with
				 //  Pink color
				 //  start position = (170, 10)
				 //  width = 75, height = 75
				 g->FillRectangle(Brushes::Pink, 170, 10, 75, 75);

				 //create a rectangle with
				 //  Blue color
				 //  start position = (170, 10)
				 //  width = 75, height = 75
				 g->DrawRectangle(Pens::Blue, 170, 10, 75, 75);
			 }

private: System::Void panel1_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
			 Graphics^ g = e->Graphics;
				 
			 //make the image become High Quality
			 g->SmoothingMode = Drawing2D::SmoothingMode::HighQuality;

			 //fill an ellipse with
			 //  White color
			 //  start position = (10, 10) (start position is always Top Left of the object)
			 //  width = 75 px, height = 50 px
			 g->FillEllipse(Brushes::White, 10, 10, 75, 50);

			 //create an ellipse with
			 //  Black color
			 //  start position = (10, 10) (start position is always Top Left of the object)
			 //  width = 75 px, height = 50 px
			 g->DrawEllipse(Pens::Black, 10, 10, 75, 50);

			 //fill a circle with
			 //  Yellow color
			 //  start position = (90, 10)
			 //  diameter = 75 px
			 g->FillEllipse(Brushes::Yellow, 90, 10, 75, 75);

			 //create an ellipse with
			 //  Red color
			 //  start postion = (90, 10)
			 //  width = 75 px, height = 75 px
			 //or you can say create a circle with
			 //  Red color
			 //  start position = (90, 10)
			 //  diameter = 75 px
			 g->DrawEllipse(Pens::Red, 90, 10, 75, 75);
			
			 //fill a rectangle with
			 //  Pink color
			 //  start position = (170, 10)
			 //  width = 75, height = 75
			 g->FillRectangle(Brushes::Pink, 170, 10, 75, 75);

			 //create a rectangle with
			 //  Blue color
			 //  start position = (170, 10)
			 //  width = 75, height = 75
			 g->DrawRectangle(Pens::Blue, 170, 10, 75, 75);
		 }
};
}

