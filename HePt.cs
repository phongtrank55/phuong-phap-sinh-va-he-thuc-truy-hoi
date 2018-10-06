using System;
using System.Collections.Generic;
using System.Text;

namespace ppsinh
{
    class HePt
    {
        
            private float _a1, _b1, _c1, _a2, _b2, _c2;
            public HePt(float a1, float b1, float c1, float a2, float b2, float c2)
            {
                _a1 = a1; _b1 = b1; _c1 = c1;
                _a2 = a2; _b2 = b2; _c2 = c2;
            }
            public int Solve()
            {
                if (_a1 == _a2 && _b1 == _b2)
                {
                    if (_c1 == _c2) return 0;
                    return -1;
                }
                return 1;
            }
            public Nghiem Cal()
            {
                float dx, dy, d;
                d = _a1 * _b2 - _a2 * _b1;
                dx = _b1 * _c2 - _b2 * _c1;
                dy = _c1 * _a2 - _c2 * _a1;
                return new Nghiem(-dx / d, -dy / d);
            }
        }
    }

