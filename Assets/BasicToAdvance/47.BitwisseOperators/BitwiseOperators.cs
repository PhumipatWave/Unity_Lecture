using UnityEngine;

namespace BitwiseOperators
{
    // Manipulate individaul bit in memory
    public class BitwiseOperators : MonoBehaviour
    {
        private void Start()
        {
            BitwiseAnd();
            BitwiseOr();
            BitwiseXOr();
            BitwiseNEG();
            BitShift();

            // Bit Mask
            // Use with Layers
            int unitLayer = 6;
            int buildingLayer = 10;
            int layerMask = 1 << unitLayer | 1 << buildingLayer;
            Physics.Raycast(transform.position, Vector3.forward, 10f, layerMask);
        }

        private void BitwiseAnd()
        {
            int a = 2;
            int b = 3;

            // 2^7 2^6 2^5 2^4 2^3 2^2 2^1 2^0
            // 128  64  32  16  8   4   2   1

            //  0   0   0   0   0   0   1   0   => 2
            //  0   0   0   0   0   0   1   1   => 3

            // And
            //  0   0   0   0   0   0   1   0   = 2

            // & : and operation in Bitwise
            // return a & b = bit index 2 is the same of a and b
            Debug.Log($"Bitwise And : {a} & {b} => {a & b}");
        }

        private void BitwiseOr()
        {
            int a = 5;
            int b = 3;

            // 2^7 2^6 2^5 2^4 2^3 2^2 2^1 2^0
            // 128  64  32  16  8   4   2   1

            //  0   0   0   0   0   1   0   1   => 5
            //  0   0   0   0   0   0   1   1   => 3

            // OR
            //  0   0   0   0   0   1   1   1   = 7

            // | : or operation in Bitwise
            Debug.Log($"Bitwise Or : {a} | {b} => {a | b}");
        }

        private void BitwiseXOr()
        {
            int a = 5;
            int b = 3;

            // 2^7 2^6 2^5 2^4 2^3 2^2 2^1 2^0
            // 128  64  32  16  8   4   2   1

            //  0   0   0   0   0   1   0   1   => 5
            //  0   0   0   0   0   0   1   1   => 3

            // EOR
            //  0   0   0   0   0   1   1   0   = 6

            // ^ : xor operation in Bitwise (Exclusive Or)
            Debug.Log($"Bitwise EOr : {a} ^ {b} => {a ^ b}");
        }

        private void BitwiseNEG()
        {
            int a = 5;
            int b = 3;

            // 2^7 2^6 2^5 2^4 2^3 2^2 2^1 2^0
            // 128  64  32  16  8   4   2   1

            //  0   0   0   0   0   1   0   1   => 5

            // NEG
            //  1   1   1   1   1   0   1   0 => -6

            // ^ : negative operation in Bitwise
            Debug.Log($"Bitwise EOr : {~a}");
        }

        private void BitShift()
        {
            // 2^7 2^6 2^5 2^4 2^3 2^2 2^1 2^0
            // 128  64  32  16  8   4   2   1

            //  0   0   0   0   0   0   0   1
            //  0   0   0   0   0   0   0   1
            //                       <=  <=

            // Bit shift : increase or decrease the bit position to amount position

            // << : Increase
            Debug.Log($"Bit shift 1 << 2 : {1 << 2}");

            // >> : Decrease
            Debug.Log($"Bit shift 8 >> 2 : {8 >> 2}");
        }
    }
}