namespace PCCC.Common.Utils
{
    public class PCCCConsts
    {
        // Default
        public const int SUCCESS = 1;
        public const int ERROR = 0;
        public const int SUCCESS_CODE = 200;
        public const string MESSAGE_SUCCESS = "Thành công";
        public const int ERROR_CODE = 501;
        public const string MESSAGE_ERROR = "Thất bại";
        public const string SERVER_ERROR = "Hệ thống đang bảo trì";
        public const int TOKEN_INVALID = 401;
        public const string MESSAGE_TOKEN_INVALID = "Đăng nhập để thực hiện chức năng này";
        public const int PERMISSION_INVALID = 402;
        public const string MESSAGE_PERMISSION_INVALID = "Bạn không có quyền thực hiện chức năng này";
        public const int TOKEN_ERROR = 403;
        public const string MESSAGE_TOKEN_ERROR = "Tài khoản của bạn đã đăng nhập ở nơi khác";

        // Login
        public const int ERROR_LOGIN_FIELDS_INVALID = 1;
        public const string MESSAGE_LOGIN_FIELDS_INVALID = "Vui lòng nhập số điện thoại";
        public const int ERROR_LOGIN_FAIL = 2;
        public const string MESSAGE_LOGIN_FAIL = "Số điện thoại không tồn tại";
        public const int ERROR_LOGIN_ACCOUNT_LOCK = 3;
        public const string MESSAGE_LOGIN_ACCOUNT_LOCK = "Tài khoản đã bị khóa";
        public const int ERROR_LOGIN_CHANGE_PASS = 4;
        public const string MESSAGE_LOGIN_CHANGE_PASS = "Bạn đã thay đổi mật khẩu vui lòng nhập mật khẩu mới!";
        public const int ERROR_LOGIN_FAIL_PASS = 5;
        public const string MESSAGE_LOGIN_FAIL_PASS = "Sai mật khẩu vui lòng nhập lại mật khẩu";

        public const int ERROR_PHONE_NOT_REGISTER = 1;
        public const string MESSAGE_PHONE_NOT_REGISTER = "Số điện thoại chưa được đăng ký";

    }
}
