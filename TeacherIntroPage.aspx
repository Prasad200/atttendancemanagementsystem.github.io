<%@ Page Title="" Language="C#" MasterPageFile="~/AMSFS.Master" AutoEventWireup="true" CodeBehind="TeacherIntroPage.aspx.cs" Inherits="Attendancemanagementsystemforstudents.TeacherIntroPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 style="width: 875px; height: 40px">Welcome to the Teacherpage and add the Teacher Info here....</h1>
    <div style="background-color:azure";>
        <center>
        <table border="1" style="height: 194px">
            <tr>
                <td>Tecaher Name</td>
                <td style="width: 277px">
                    <asp:TextBox ID="TxtTeacherName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td style="width: 277px">
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course</td>
                <td style="width: 277px">
                    <asp:DropDownList ID="DDLCourse" runat="server" DataSourceID="SqlDataSource1" AppendDataBoundItems="true" DataTextField="cname" DataValueField="cname">
                        <asp:ListItem Value="0" Text="--Select Courses--"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineattendenceSystemConnectionString %>" SelectCommand="SELECT [cname] FROM [courses]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Qualification</td>
                <td style="width: 277px">
                    <asp:TextBox ID="TxtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 57px">
                    <asp:Button ID="ButTeacher" runat="server" Text="INSERT" OnClick="ButTeacher_Click" /></td>
                <td style="height: 57px; width: 277px;">
                    <asp:Label ID="LabMsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>
            </center>
    </div>
</asp:Content>
