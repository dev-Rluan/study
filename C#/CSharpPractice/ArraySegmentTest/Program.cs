using System;
// ArraySegmant 연습 겸 확인 배열을 참조할때 가져온 데이터의 크기보다 세그먼트에 넣을 양이 크더라도 
// 원본 바이트 배열만큼 넣을 수 있다. 
// 단 첫 Offset위치는 세그먼트를 따라간다.
namespace ArraySegmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[24];
            int cnt = 0;
            ArraySegment<byte> segment = new ArraySegment<byte>(buffer, 4, 20);
            Array.Copy(BitConverter.GetBytes(10), 0,segment.Array, segment.Offset , sizeof(int));
            Console.WriteLine("?");
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset+cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset + cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset + cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset + cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset + cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Console.WriteLine(segment.Offset + cnt);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));
            cnt += sizeof(int);
            Array.Copy(BitConverter.GetBytes(10), 0, segment.Array, segment.Offset + cnt, sizeof(int));

            Console.WriteLine(buffer);
        }
    }
}
