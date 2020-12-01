<%@ Page Title="" Language="C#" MasterPageFile="~/AMSFS.Master" AutoEventWireup="true" CodeBehind="StudentIntroPage.aspx.cs" Inherits="Attendancemanagementsystemforstudents.StudentIntroPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Welcome to the StudentInfoPage and add the Student Info here....</h1>
    <div style="background-color:azure;">
        <center>
        <table border="1">
            <tr>
                <td>FirstName</td>
                <td>
                    <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>LastName</td>
                <td>
                    <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Pname</td>
                <td>
                    <asp:TextBox ID="TxtPname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 22px">
                    <asp:Button ID="ButStudent" runat="server" Text="Insert" OnClick="ButStudent_Click" /></td>
                <td style="height: 22px">
                    <asp:Label ID="LabMsg" runat="server" Text="" Forecolor="Green"></asp:Label></td>
            </tr>
        </table>
            </center>
    </div>
</asp:Content>
