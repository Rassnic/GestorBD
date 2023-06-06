<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GestorBD.WF.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
<style>
    .gradient-custom {
/* fallback for old browsers */
background: #6a11cb;

/* Chrome 10-25, Safari 5.1-6 */
background: -webkit-linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1));

/* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
background: linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1))
}
</style>
<section class="vh-100 gradient-custom">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">

              <h2 class="fw-bold mb-2 text-uppercase">Login</h2>
              <%--<p class="text-white-50 mb-5">Please enter your login and password!</p>--%>

              <div class="form-outline form-white mb-4">
                <input type="text" runat="server" id="user" class="form-control form-control-lg" placeholder="Usuario"/>                
              </div>

              <div class="form-outline form-white mb-4">
                <input type="Password"  runat="server" id="pass" class="form-control form-control-lg" placeholder="Password"/>                
              </div>
              
              <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="login_Click" class="btn btn-outline-light btn-lg px-5"/>
            </div>

            <div>
              <%--<p class="mb-0">Don't have an account? <a href="#!" class="text-white-50 fw-bold">Sign Up</a></p>--%>
            </div>

          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    <script src="../Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
