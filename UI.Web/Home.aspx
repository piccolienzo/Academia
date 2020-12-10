<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UI.Web.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        

        .centered-text{
   			text-align:center;
   		}
   		
   		.centered-content{
   			width: 25%;
    		margin: 0 auto;
   		}
        .input-group{
        margin: 0 auto;
        }
        
        
        
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">

    <asp:Panel CssClass="centered-content" Width="50%" runat="server">

    <div>
        <h2>¡Bienvenido <asp:Label Text="Usuario" runat="server" ID="LblUserBienvenida" OnLoad="LblUserBienvenida_Load" />!
        </h2>
    </div>
    </asp:Panel>

</asp:Content>
