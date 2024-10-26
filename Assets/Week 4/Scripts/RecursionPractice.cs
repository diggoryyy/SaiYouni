using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    //Cách hoạt động của đệ quy
    //Điều kiện dừng: Mỗi hàm đệ quy cần có một điều kiện để "dừng lại" không gọi chính nó nữa.Đây là điểm quan trọng để tránh gọi vô hạn và gây lỗi.
    //Gọi lại chính hàm: Trong thân hàm, nó sẽ gọi chính nó nhưng với một giá trị khác, thường là một giá trị nhỏ hơn hoặc đơn giản hơn.
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tính giai thừa của một số
        BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3(); // Chuỗi Fibonacci
        BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính giai thừa của n
        
        int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }
    

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        
        int Sum(int n)
        {
            if (n <= 1) return n;
            return n + Sum(n - 1);
        }
    }
    

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
        void CountDown(int n)
        {
            if (n < 1) return;
            Debug.Log(n);
            CountDown(n - 1);
        }
    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        int ABC(int a, int b)
        {
            if (b == 0) return a;
            return ABC(b, a % b);
        }
    }
}
