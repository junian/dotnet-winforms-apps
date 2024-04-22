using namespace System;

namespace BouncingBall
{
	public value class Vector2D
	{
	public:
		Vector2D(float _x, float _y)
		{
			X = _x;
			Y = _y;
		}

		float GetLength()
		{
			return (float) Math::Sqrt(X * X + Y * Y);
		}

		float DotProduct(Vector2D value)
		{
			return (X * value.X + Y * value.Y);
		}

		Vector2D Normalize()
		{
			float length = GetLength();
			X /= length;
			Y /= length;
			return *this;
		}

		static Vector2D operator+(Vector2D a, Vector2D b)
		{
			return Vector2D(a.X + b.X, a.Y + b.Y);
		}

		static Vector2D operator-(Vector2D a, Vector2D b)
		{
			return Vector2D(a.X - b.X, a.Y - b.Y);
		}

		static Vector2D operator*(Vector2D a, Vector2D b)
		{
			return Vector2D(a.X * b.X, a.Y * b.Y);
		}

		static Vector2D operator*(float a, Vector2D b)
		{
			return Vector2D(a * b.X, a * b.Y);
		}

		static Vector2D operator*(Vector2D a, float b)
		{
			return Vector2D(a.X * b, a.Y * b);
		}

		property float X
		{
			float get()
			{
				return x;
			}
			void set(float value)
			{
				x = value;
			}
		}

		property float Y
		{
			float get()
			{
				return y;
			}
			void set(float value)
			{
				y = value;
			}
		}

	private:

		float x;
		float y;
	};
}