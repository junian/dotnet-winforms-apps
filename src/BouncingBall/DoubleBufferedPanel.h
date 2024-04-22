#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Diagnostics;
using namespace System::Windows::Forms;

namespace BakaDevBouncingBall {

	/// <summary>
	/// Summary for DoubleBuffererPanel
	/// </summary>
	public ref class DoubleBufferedPanel :  public Panel
	{

	public:
		DoubleBufferedPanel(void)
			:Panel()
		{
			this->DoubleBuffered = true;
			this->SetStyle(ControlStyles::AllPaintingInWmPaint |
				ControlStyles::UserPaint |
				ControlStyles::OptimizedDoubleBuffer, true);
            this->UpdateStyles();
		}
	};
}
