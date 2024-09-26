# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
    UnityEngine.Debug.Log("Max Int: " + int.MaxValue); //Max Int: 2147483647
    UnityEngine.Debug.Log("Max Float: " + float.MaxValue); //Max Float: 3.402823E+38
    UnityEngine.Debug.Log("Max Double: " + double.MaxValue); //Max Double: 1.79769313486232E+308

## 2. Nhờ AI Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
Kế Hoạch Thực Hiện 30 Ngày

Tuần 1: Cài Đặt và Làm Quen với Unity

Ngày 1-2: Cài đặt Unity và Làm quen với Giao diện
Tải xuống và cài đặt Unity Hub và Unity Editor.
Tạo một dự án mới với tên "Lost in the Haunted Forest."
Khám phá giao diện Unity: Scene, Game, Inspector, Project.

Ngày 3-4: Tạo Môi Trường Rừng
Tạo khu rừng:
Sử dụng các asset miễn phí từ Unity Asset Store hoặc tự tạo cây cối, đường đi, và các đối tượng khác trong rừng.
Thêm các yếu tố đặc biệt như tảng đá, ao nước, hoặc các vật thể ma quái.

Ngày 5-7: Nhân Vật và Điều Khiển
Tạo mô hình nhân vật:
Sử dụng asset miễn phí hoặc tạo một mô hình đơn giản cho nhân vật.
Lập trình điều khiển:
Viết script C# cho việc di chuyển nhân vật (dùng Input.GetAxis cho di chuyển và nhảy).
Thêm cơ chế tấn công (như đòn đánh melee hoặc sử dụng vũ khí).


Tuần 2: Kẻ Thù và Nhiệm Vụ

Ngày 8-10: Kẻ Thù và AI
Tạo mô hình kẻ thù (ma quái):
Sử dụng asset miễn phí hoặc tự tạo một mô hình cho các sinh vật ma quái.
Lập trình AI cho kẻ thù:
Viết script cho kẻ thù di chuyển và tấn công người chơi.
Tạo các hành vi như theo dõi người chơi hoặc ẩn nấp.

Ngày 11-13: Cỏ Bốn Lá và Nhiệm Vụ
Tạo mô hình cỏ bốn lá:
Tạo hoặc tìm một asset cho cỏ bốn lá mà người chơi sẽ thu thập.
Lập trình nhiệm vụ thu thập:
Viết script kiểm tra xem người chơi đã thu thập đủ cỏ bốn lá hay chưa để mở khóa lối thoát.

Ngày 14: Giao Diện Người Dùng (UI)
Thiết kế UI cơ bản:
Sử dụng Unity UI để tạo thanh sức khỏe, hiển thị số lượng cỏ bốn lá và điểm số.
Thêm menu tạm dừng và thông báo cho nhiệm vụ.


Tuần 3: Tinh Chỉnh Gameplay và Cấp Độ Mới

Ngày 15-17: Tạo Nhiều Cấp Độ Rừng
Thiết kế cấp độ mới:
Tạo thêm các khu vực trong rừng với chủ đề khác nhau (ví dụ: khu vực tối tăm, khu vực nhiều cây cối).
Lập trình chuyển cảnh:
Tạo hệ thống cho phép người chơi di chuyển giữa các khu vực.

Ngày 18-21: Cải Thiện Gameplay
Thêm các yếu tố mới:
Thêm các tính năng như các chướng ngại vật trong rừng hoặc các nhiệm vụ phụ.
Tinh chỉnh hành vi của kẻ thù để tăng độ khó.

Tuần 4: Tinh Chỉnh và Hoàn Thiện

Ngày 22-24: Âm Thanh và Hiệu Ứng
Thêm âm thanh:
Tìm kiếm và thêm âm thanh cho các hành động: di chuyển, tấn công, và tiếng động ma quái.
Sử dụng hiệu ứng hình ảnh:
Thêm hiệu ứng ánh sáng và mờ để tăng cường cảm giác hồi hộp.

Ngày 25-27: Kiểm Tra và Sửa Lỗi
Chạy thử nghiệm:
Chơi thử game để tìm lỗi và điều chỉnh cân bằng gameplay.
Sửa lỗi và cải thiện:
Ghi chú các vấn đề và sửa chữa, nâng cao trải nghiệm người chơi.

Ngày 28-30: Xuất Bản và Phản Hồi

Xuất bản game:
Tạo bản build cho game và chia sẻ trên các nền tảng như itch.io hoặc GameJolt.
Thu thập phản hồi:
Ghi nhận ý kiến từ người chơi để cải thiện game trong tương lai.

## 3. Khai Báo Thêm 5 Methods Cho Class Enemy
void Run(){
    ...
}

void Jump(){
    ...
}

void Fly(){
    ...
}

void Walk(){
    ...
}

void Attack(){
    ...
}
## 4. Khai Báo Thêm 5 Biến Cho Class Enemy
public int currentHealth = 5;
public int maxHealth = 10;
public float speed = 3f;
public bool isAlive = true;
public string enemyType = "Boss";

## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`
Câu lệnh int[] scores = new int[10]; trong C# (và Unity) có nghĩa là bạn đang tạo một mảng số nguyên có tên là scores với kích thước 10. Dưới đây là phần giải thích chi tiết cho từng phần của câu lệnh:

Phân tích từng phần:
int[]:

Đây là khai báo kiểu dữ liệu của mảng.
int là kiểu dữ liệu của các phần tử trong mảng (trong trường hợp này là số nguyên).
[] chỉ ra rằng đây là một mảng.
scores:

Đây là tên biến của mảng. Bạn có thể sử dụng tên này để truy cập và thao tác với mảng trong mã của bạn.
=:

Đây là toán tử gán. Nó gán giá trị bên phải cho biến bên trái.
new int[10]:

new là từ khóa được sử dụng để tạo một đối tượng mới. Trong trường hợp này, bạn đang tạo một mảng mới.
int[10] chỉ định rằng bạn muốn tạo một mảng có kích thước 10, có nghĩa là mảng này sẽ có 10 phần tử. Tất cả các phần tử trong mảng này sẽ được khởi tạo với giá trị mặc định của kiểu dữ liệu int, đó là 0.
Kết quả:
Khi câu lệnh này được thực hiện, bạn sẽ có một mảng scores với 10 phần tử, tất cả đều có giá trị là 0. Bạn có thể truy cập các phần tử trong mảng bằng chỉ số (index), bắt đầu từ 0 đến 9.

## 6. Nhờ AI Giải Thích Về Rigidbody
Trong Unity, Rigidbody là một thành phần (component) rất quan trọng được sử dụng để tạo ra các đối tượng có thể tương tác vật lý trong môi trường 3D hoặc 2D. Nó cho phép bạn áp dụng các thuộc tính vật lý như trọng lực, va chạm, và lực tác động lên đối tượng. Dưới đây là một số điểm chính về Rigidbody:

Các Tính Năng Của Rigidbody
Tương tác Vật Lý:

Khi bạn gán một Rigidbody cho một đối tượng, nó có thể bị ảnh hưởng bởi trọng lực và các lực khác như đẩy hoặc kéo.
Rigidbody tự động tính toán các phản ứng va chạm giữa các đối tượng trong trò chơi.
Trọng lực:

Khi thuộc tính Use Gravity được bật, Rigidbody sẽ bị ảnh hưởng bởi trọng lực, có nghĩa là nó sẽ rơi xuống khi không có lực nào khác tác động lên nó.
Kinematic:

Nếu bạn đặt Rigidbody là kinematic, đối tượng sẽ không bị ảnh hưởng bởi lực vật lý và sẽ chỉ di chuyển khi bạn điều khiển nó thông qua mã.
Lực và Impulse:

Bạn có thể áp dụng lực (Force) hoặc xung lực (Impulse) lên Rigidbody bằng các phương thức như AddForce() hoặc AddTorque() để tạo ra các hiệu ứng vật lý trong trò chơi.
Va chạm:

Rigidbody cho phép bạn xác định cách mà các đối tượng tương tác với nhau khi va chạm, giúp bạn xử lý va chạm và tạo ra phản ứng phù hợp.
Cách Sử Dụng Rigidbody
Để sử dụng Rigidbody, bạn cần thực hiện các bước sau:

Gán Rigidbody:

Chọn đối tượng trong Hierarchy, sau đó thêm component Rigidbody thông qua menu Add Component.
Cài đặt thuộc tính:

Trong Inspector, bạn có thể điều chỉnh các thuộc tính của Rigidbody như trọng lực, kinematic, mass (khối lượng), drag (ma sát), và nhiều thuộc tính khác.
Lập trình tương tác:

Bạn có thể sử dụng mã để điều khiển đối tượng với Rigidbody. 

## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
Để chia lấy dư một số bất kỳ trong C#, bạn sử dụng toán tử % (toán tử chia lấy dư). Toán tử này trả về phần dư của phép chia giữa hai số.

## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
Các kiểu dữ liệu khác như: 
 - Vector2
 - Vector3
 - Transform
 - List<>
 - Quaternion

## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác
- ++, --,...
- is : check obj
- as : ep kieu


