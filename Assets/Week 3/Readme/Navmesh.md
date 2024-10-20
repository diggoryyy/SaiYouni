# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.


NavMesh Obstacle là một thành phần trong Unity được sử dụng để tạo ra các vật cản ảnh hưởng đến hệ thống điều hướng (Navigation) của các đối tượng trong game. Khi một đối tượng được gắn NavMesh Obstacle, nó sẽ trở thành vật cản trên NavMesh, buộc các nhân vật phải tìm các tuyến đường khác để tránh vật cản hoặc không thể tiếp cận khu vực đó nếu không có đường vòng.

Cách sử dụng NavMesh Obstacle:
Thêm NavMesh Obstacle vào đối tượng:

Trong Unity, chọn đối tượng muốn làm vật cản.
Trên thanh menu, vào Component > Navigation > NavMesh Obstacle để thêm thành phần này.
Các thuộc tính chính cần cấu hình:

Shape: Đặt hình dạng của vật cản (hình hộp hoặc hình trụ) tùy theo hình dạng của đối tượng.
Carving: Nếu bật tùy chọn Carving, đối tượng sẽ đục ra khỏi NavMesh và các nhân vật sẽ tính toán đường đi khác để tránh nó. Điều này hữu ích khi bạn có các vật cản động như cổng mở ra hoặc tảng đá rơi xuống.
Carve Only Stationary: Khi bật, NavMesh Obstacle chỉ đục khi vật cản đứng yên. Điều này giảm tải cho hệ thống, vì Unity sẽ không cập nhật NavMesh liên tục khi vật cản đang di chuyển.
Sử dụng vật cản tĩnh và động:

Vật cản tĩnh: Các đối tượng không di chuyển như tường, cột... Đây là trường hợp cơ bản nhất, chỉ cần đặt NavMesh Obstacle và không cần bật Carving.
Vật cản động: Những đối tượng có thể di chuyển như cánh cửa, cầu nâng... Bật tùy chọn Carving để NavMesh có thể tự động cập nhật và đục phần vật cản khỏi lưới khi nó thay đổi.
Kiểm tra hệ thống NavMesh:

Sau khi thêm NavMesh Obstacle, bạn cần kiểm tra NavMesh trong Scene View để chắc chắn rằng các vật cản được xử lý đúng cách. Đảm bảo rằng các nhân vật không thể đi qua các vật cản và họ có thể điều hướng quanh những khu vực đã bị đục.
Ứng dụng của NavMesh Obstacle:
Game chiến thuật và RPG: Để tạo ra các tòa nhà, vật cản, rào chắn mà kẻ thù hoặc nhân vật phải tìm cách tránh né.
Game hành động: Để mô phỏng các chướng ngại vật hoặc các vật cản tạm thời có thể ảnh hưởng đến đường đi của các đối tượng.
Sử dụng đúng cách NavMesh Obstacle sẽ giúp hệ thống điều hướng của game trở nên linh hoạt hơn và cải thiện tính thực tế của các tình huống di chuyển trong game.