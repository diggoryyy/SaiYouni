using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Debug.Log(number);   
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;           
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {       
            if (number > maxNumber) maxNumber = number;
        }
        Debug.Log(maxNumber);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int evenNumber = 0;
        foreach (int number in numbers)
        {       
            if (number%2 ==0 ) evenNumber +=1 ;
        }
        Debug.Log(evenNumber);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        List<string> schools = new List<string> { "UIT", "RMIT", "HCMU", "SGU", "BKU" };
        foreach (string school in schools)
        {
            Debug.Log(school);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        List<string> schools = new List<string> { "UIT", "Vin", "HCMU", "SGU", "BKU" };
        string longestName = schools[0];
        foreach (string school in schools)
        {
            if (school.Length > longestName.Length) longestName = school;
        }
        Debug.Log(longestName);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int oddNumber = 0;
        foreach (int number in numbers)
        {       
            if (number%2 ==1 ) oddNumber +=number ;
        }
        Debug.Log(oddNumber);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {       
            if (number%2 ==0 ) Debug.Log(number);
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        int[] numbers = { 1, 2, 3, 4, 5 };
        int findNumber = 10;
        bool axist = false;
        foreach (int number in numbers)
        {
            if (number == findNumber) axist = true;
        }

        if (axist == true) Debug.Log("Number " + findNumber + " does exist in the array");
        else Debug.Log("Number " + findNumber + " doesn't exist in the array");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        float[] numbers = { -1, -2, 3, 4, 5 };
        int countNeg = 0;
        foreach (float number in numbers)
        {       
            if (number <0 ) countNeg+=1;    
        }
        Debug.Log(countNeg);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        float[] numbers = { -1, -2, 3, 4, 15 };
        int countNeg = 0;
        foreach (float number in numbers)
        {       
            if (number >10 ) countNeg+=1;    
        }
        Debug.Log(countNeg);
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        List<string> names = new List<string> { "Hakura", "Kukoza", "Kizaa", "Rasibaha", "Lazy" };
        string shortestName = names[0];
        foreach (string name in names)
        {
            if (name.Length < shortestName.Length) shortestName = name;
        }
        Debug.Log(shortestName);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] doubleNumbers = new int[numbers.Length];
        int index = 0;
        foreach (int number in numbers)
        {
            doubleNumbers[index] = number*2;
            index++;
        }
        // Debug.Log(doubleNumbers);
        Debug.Log(string.Join(",",doubleNumbers));
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        if (numbers.Length <2) return;

        int temp1 = int.MinValue; //min
        int temp2 = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > temp1)
            {
                temp2 = temp1;
                temp1 = number;
            }
            else if (number > temp2 && number != temp1)
            {
                temp2 = number;
            }    
        }
        if (temp2 == int.MinValue)
        {
            Debug.Log("The 2nd largest value was not found");
        }
        else
        {
            Debug.Log("The 2nd largest element in the array is: " + temp2);
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        List<string> strs = new List<string> { "Aakura", "AKukoza", "Kizaa", "Rasibaha", "Allazy" };
        foreach (string str in strs)
        {
            if(str.StartsWith("A")) Debug.Log(str);
        }

    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        List<string> strs = new List<string> { "Hello", "AKukoza", "Kizaa", "Rasibaha", "Allazy" };
        foreach (string str in strs)
        {
            if(str == "Hello") Debug.Log("true");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        int[] numbers = { 0, 1, -2, 3, -4, 5, 6, -7 };
        foreach (int number in numbers)
        {
            if (number < 0) Debug.Log(number);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int[] numbers = { 0, 1, -2, 3, -4, 5, 6, -7 };
        int inf = 3;
        int count =0;
        foreach (int number in numbers)
        {
            if (number == inf) 
            count++;       
        }
        Debug.Log(count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        int[] numbers = { 10, 5, 2, 15, 26, 1 };

        List<int> tenList = new List<int>();
        foreach (int number in tenList)
        {
            if (number > 10)
                tenList.Add(number);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        List<string> strList = new List<string> { "Hello", "AKukoza", "Kizaa", "Rasibaha", "Allazy" };
        foreach (string str in strList)
        {
            if(str.Length > 5) Debug.Log(str);
        }
    }

}
