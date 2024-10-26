using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        bool hasValidTicket = true;
        bool isVIP = false;
        bool isInvited = false; 

        if (hasValidTicket || isVIP || isInvited)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        bool isFirstPrizeWinner = false; 
        bool isSecondPrizeWinner = true; 
        bool isThirdPrizeWinner = false; 

        if (isFirstPrizeWinner || isSecondPrizeWinner || isThirdPrizeWinner)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        bool hasStableIncome = true;
        bool hasCollateral = false; 
        bool hasGuarantor = false;

        if (hasStableIncome || hasCollateral || hasGuarantor)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        bool hasExcellentGrades = true; 
        bool hasGoodExtracurricular = false; 
        bool hasFinancialDifficulty = false; 

        if (hasExcellentGrades || hasGoodExtracurricular || hasFinancialDifficulty)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        bool hasValidEmail = true;
        bool hasVerifiedPhone = false;
        bool isRegisteredOnline = false; 

        if (hasValidEmail || hasVerifiedPhone || isRegisteredOnline)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        bool hasDrivingLicense = true;
        bool isCarRegistered = false;
        bool hasCarInsurance = false;

        if (hasDrivingLicense || isCarRegistered || hasCarInsurance)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        bool isAdmin = true; 
        bool hasAccessPermission = false;
        bool hasAccessCode = false;

        if (isAdmin || hasAccessPermission || hasAccessCode)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        bool hasTeacherRecommendation = true; 
        bool hasPassedEntranceExam = false;
        bool hasRelevantExperience = false; 

        if (hasTeacherRecommendation || hasPassedEntranceExam || hasRelevantExperience)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        bool hasPromoCode = false; 
        bool isVIPMember = true; 
        bool isAppFreePeriod = false; 

        if (hasPromoCode || isVIPMember || isAppFreePeriod)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        bool hasSpentAboveThreshold = true;
        bool isLoyalCustomer = false; 
        bool hasPromotionProgram = false;

        if (hasSpentAboveThreshold || isLoyalCustomer || hasPromotionProgram)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("fail");
        }
    }
}
