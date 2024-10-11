using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
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


    // NAY CHAC LAM BAI TAP FOR NHUNG DE NHAM THANH FOREACH NHI?


    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += number[i];
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
        for(int i = 0;i< numbers.Length; i++)
        {
            if (numbers[i] > maxNumber) maxNumber = numbers[i];
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
        for (int i = 0;i< numbers.Length; i++)
        {       
            if (numbers[i]%2 ==0 ) evenNumber +=1 ;
        }
        Debug.Log(evenNumber);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        List<string> schools = new List<string> { "UIT", "RMIT", "HCMU", "SGU", "BKU" };
        for (int i = 0; i < schools.Count; i++)
        {
            Debug.Log(schools[i]);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        List<string> schools = new List<string> { "UIT", "Vin", "HCMU", "SGU", "BKU" };
        string longestName = schools[0];
        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].Length > longestName.Length) longestName = schools[i];
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
        for (int i=0; i < numbers.Length;i++)
        {
            if (numbers[i] % 2 == 1) oddNumber += numbers[i];
        }
        Debug.Log(oddNumber);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) Debug.Log(numbers[i]);
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
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == findNumber) axist = true;
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
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0) countNeg += 1;
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
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 10) countNeg += 1;
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
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Length < shortestName.Length) shortestName = names[i];
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
        for (int i = 0; i < numbers.Length; i++)
        {
            doubleNumbers[index] = numbers[i] * 2;
            index++;
        }
        // Debug.Log(doubleNumbers);
        Debug.Log(string.Join(",", doubleNumbers));
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };
        if (numbers.Length < 2) return;

        int temp1 = int.MinValue; //min
        int temp2 = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > temp1)
            {
                temp2 = temp1;
                temp1 = numbers[i];
            }
            else if (numbers[i] > temp2 && numbers[i] != temp1)
            {
                temp2 = numbers[i];
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
        for (int i = 0; i < strs.Count; i++)
        {
            if (strs[i].StartsWith("A")) Debug.Log(strs[i]);
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        List<string> strs = new List<string> { "Hello", "AKukoza", "Kizaa", "Rasibaha", "Allazy" };
        for (int i = 0; i < strs.Count; i++)
        {
            if (strs[i] == "Hello") Debug.Log("true");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        int[] numbers = { 0, 1, -2, 3, -4, 5, 6, -7 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0) Debug.Log(numbers[i]);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int[] numbers = { 0, 1, -2, 3, -4, 5, 6, -7 };
        int inf = 3;
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == inf)
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
        for (int i = 0; i < tenList.Count; i++)
        {
            if (tenList[i] > 10)
                tenList.Add(tenList[i]);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        List<string> strList = new List<string> { "Hello", "AKukoza", "Kizaa", "Rasibaha", "Allazy" };
        for (int i = 0; i < strList.Count; i++)
        {
            if (strList[i].Length > 5) Debug.Log(strList[i]);
        }
    }
}
