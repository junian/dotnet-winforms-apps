using namespace System::Drawing;
using namespace System::Collections::Generic;

namespace BakaDevBouncingBall
{
	public ref class BouncingBalls
	{
	public:
		static float Gravity = 9.81f;

		BouncingBalls(float w, float h)
		{
			balls = gcnew List<Ball^>();
			boundary = gcnew RectangleF(0.0f, 0.0f, w, h);
			Area = 0.0f;
		}

		void Add(Ball^ ball)
		{
			balls->Add(ball);
			Area += (float) Math::PI * ball->Radius * ball->Radius;
		}

		void DestroyAll()
		{
			balls->Clear();
			Area = 0.0f;
		}

		void DrawBalls(Graphics^ g)
		{
			for each(Ball^ i in balls)
			{
				i->Draw(g);
			}
		}

		void MoveBalls(float t)
		{
			for each(Ball^ i in balls)
			{
				i->Velocity->X *= 0.999f;
				i->Velocity->Y += Gravity * t;
				i->Move();
			}
		}

		void BallToWallCollision(float t)
		{
			for each(Ball^ i in balls)
			{
				if (i->Position->X < boundary->X)
                {
                    i->Velocity->X *= -0.9f;
                    i->Position->X = boundary->X;
                }
                else if (i->Position->X + i->Diameter > boundary->Width)
                {
                    i->Velocity->X *= -0.9f;
                    i->Position->X = boundary->Width - i->Diameter;
                }

                if (i->Position->Y < boundary->Y)
                {
                    i->Velocity->Y *= -0.9f;
                    i->Position->Y = boundary->Y;
                }
                else if (i->Position->Y + i->Diameter > boundary->Height)
                {
                    i->Velocity->Y *= -0.9f;
                    i->Position->Y = boundary->Height - i->Diameter;
                }
			}
		}

		void BallToBallCollision(float t)
		{
			for(int i=0; i < balls->Count; i++)
			{
				for(int j=i+1; j < balls->Count; j++)
				{
					if(balls[i]->IsColliding(balls[j]))
						balls[i]->BounceAction(balls[j]);
				}
			}
		}

		property int Count
		{
			int get()
			{
				return balls->Count;
			}
		}

		property float Area
		{
			void set(float value)
			{
				area = value;
			}
			float get()
			{
				return area;
			}
		}
	private:
		float area;
		List<Ball^>^ balls;
		RectangleF^ boundary;
	};
}