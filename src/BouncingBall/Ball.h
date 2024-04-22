using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Drawing2D;

namespace BouncingBall 
{
	public ref class Ball 
	{
	public:
		Ball(float x, float y, float r, float vx, float vy, Color color)
		{
			pos = gcnew Vector2D(x, y);
			speed = gcnew Vector2D(vx, vy);
			Radius = r;
			FillColor = color;
		}

		void Draw(Graphics^ g)
		{
			g->FillEllipse(gcnew LinearGradientBrush(
				PointF(pos->X, pos->Y),
				PointF(pos->X + d, pos->Y + d),
				Color::White,
				FillColor),
				//gcnew SolidBrush(FillColor),
				pos->X, pos->Y, d, d);
			//g->DrawEllipse(Pens::Black, pos->X, pos->Y, d, d);
		}

		bool IsColliding(Ball^ ball)
		{
			float dx = (pos->X + r) - (ball->pos->X + ball->Radius);
			float dy = (pos->Y + r) - (ball->pos->Y + ball->Radius);
			float dr = r + ball->Radius;

			return (dx*dx + dy*dy <= dr*dr);
		}

		void BounceAction(Ball^ ball)
		{
			Vector2D dvect = *pos + Vector2D(r, r) - (*(ball->pos) + Vector2D(ball->r, ball->r));

			float d = dvect.GetLength();
			
			if(d == 0.0f) 
				d = 0.0000001f;

			Vector2D mtd = dvect * ((Radius + ball->Radius - d) / d);

			float im1 = 1.0f / Mass;
			float im2 = 1.0f / ball->Mass;

			*pos = *pos + (mtd * (im1 / (im1 + im2)));
			*(ball->Position) = *(ball->Position) - (mtd * (im2 / (im1 + im2)));

			Vector2D dv = *Velocity - *(ball->Velocity);
			float vn = dv.DotProduct(mtd.Normalize());

			if(vn > 0.0f)
				return;

			float i = (-(1.0f + 0.85f) * vn) / (im1 + im2);

			Vector2D imp = mtd * i;

			*Velocity = *Velocity + (imp * im1);
			*(ball->Velocity) = *(ball->Velocity) - (imp * im2);
		}

		void Move()
		{
			*pos = *speed + *pos;
		}

		property float Radius
		{
			void set(float value)
			{
				r = (value > 0.0f) ? value: 1.0f;
				d = r * 2;
				m = 4 * (float) Math::PI * r * r * r /3;
			}
			float get()
			{
				return r;
			}
		}

		property float Diameter
		{
			float get()
			{
				return d;
			}
		}

		property float Mass
		{
			float get()
			{
				return m;
			}
		}

		property Vector2D^ Position
		{
			void set(Vector2D^ value)
			{
				pos = value;
			}
			Vector2D^ get()
			{
				return pos;
			}
		}

		property Vector2D^ Velocity
		{
			void set(Vector2D^ value)
			{
				speed = value;
			}
			Vector2D^ get()
			{
				return speed;
			}
		}

		property Color FillColor
		{
			void set(Color value)
			{
				color = value;
			}
			Color get()
			{
				return color;
			}
		}

	private:

		float r;
		float d;
		float m;

		Vector2D ^pos;
		Vector2D ^speed;

		Color color;
	};
}