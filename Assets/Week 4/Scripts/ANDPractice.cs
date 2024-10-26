using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        {

            int age = 20;
            bool hasLicense = true;
            int exp = 2;

            // Kiểm tra điều kiện
            if (age > 18 && hasLicense && exp > 1)
            {
                Debug.Log("qualified");
            }
            else
            {
                Debug.Log("not qualified");
            }
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {

        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        {

            bool hasTicket = true;
            bool isRegistered = true;
            bool hasHeartCondition = true;


            if (hasTicket && isRegistered && !hasHeartCondition)
            {
                Debug.Log("qualified");
            }
            else
            {
                Debug.Log("not qualified");
            }
        }
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        {

            float averageScore = 1f;
            float extracurricularScore = 1f;
            bool hasDisciplinaryRecord = true;

            if (averageScore >= 9.0f && extracurricularScore >= 8.0f && !hasDisciplinaryRecord)
            {
                Debug.Log("qualified");
            }
            else
            {
                Debug.Log("not qualified");
            }
        }
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        bool isValidEmail = true;
        bool isPhoneVerified = true;
        bool hasPaidFee = true;

        if (isValidEmail && isPhoneVerified && hasPaidFee)
        {
            Debug.Log("qualified");
        }
        else
        {
            Debug.Log("not qualified");
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        float finalScore = 1f;
        float failedSubjects = 1f;
        float attendanceScore = 1f;

        if (finalScore < 5.0f && failedSubjects <= 2 && attendanceScore > 0.75)
        {
            Debug.Log("qualified");
        }
        else
        {
            Debug.Log("not qualified");
        }
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        bool hasDegree = true;
        float yearsOfExperience = 3f;
        bool passedAptitudeTest = true;

        if (hasDegree && yearsOfExperience >= 2 && passedAptitudeTest)
        {
            Debug.Log("qualified");
        }
        else
        {
            Debug.Log("not qualified");
        }
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        {
            float availableFunds = 1f;      
            float itemPrice =1f;           
            bool isItemInStock = true;        
            bool isEligibleForDiscount =true;
            if (availableFunds >= itemPrice && isItemInStock && isEligibleForDiscount)
            {
                Debug.Log("qualified");
            }
            else
            {
                Debug.Log("not qualified");
            }
        }
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        float yearsOfService = 6f;
        bool metWorkTarget = true;
        bool hasDisciplinaryRecord = true;

        if (yearsOfService > 5 && metWorkTarget && !hasDisciplinaryRecord)
        {
            Debug.Log("qualified");
        }
        else
        {
            Debug.Log("not qualified");
        }
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
    }
}
