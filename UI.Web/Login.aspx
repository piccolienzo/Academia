<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <style>

        
        .centered-text{
   			text-align:center;
   		}
   		
   		.centered-content{
   			
    		margin: 0 auto;
            width: 25%;
            margin-top:15%;
            margin-bottom:15%;
            
   		}
        .input-group{
        margin: 0 auto;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
    <br />
    <div class="centered-content centered-text form-signin">

        <h2>Login</h2>
        <div class="form-group input-group">                 
            <asp:TextBox ID="TextBoxUsuarioLogin" runat="server" placeholder="Usuario" CssClass="form-control form-control-lg" ></asp:TextBox>            
        </div>
        
        <div class="form-group input-group">                                 
            <asp:TextBox ID="TextBoxClaveLogin" runat="server" placeholder="Contraseña" TextMode="Password"    CssClass="form-control form-control-lg"></asp:TextBox>						
        </div>
        <br />
        <div class="">         
            <asp:Button ID="BotonIngresar" runat="server" OnClick="ButtonIngresarLogin_Click" Text="Ingresar"  CssClass="btn btn-lg btn-block btn-dark" />
        </div>

    </div>
        </div>
    </form>
</body>
</html>


