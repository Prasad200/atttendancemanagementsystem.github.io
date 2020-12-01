<%@ Page Title="" Language="C#" MasterPageFile="~/AMSFS.Master" AutoEventWireup="true" CodeBehind="CourseIntroPage.aspx.cs" Inherits="Attendancemanagementsystemforstudents.CourseIntroPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to the Course Page and add the Course Info here......</h1>
    <div style="background-color:azure";>
        <center>
            <table border="1">
                <tr>
                    <td>Course Name</td>
                    <td style="width: 339px">
                        <asp:TextBox ID="TxtCourseName" runat="server"></asp:TextBox>

                    </td>

                </tr>
        <tr>
            <td>Course Time</td>
            <td style="width: 339px">
                <asp:TextBox ID="TxtTime" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Course Credits</td>
            <td style="width: 339px">
                <asp:TextBox ID="TxtCredits" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 70px">
                <asp:Button ID="ButCourse" runat="server" Text="Insert New Course" OnClick="ButCourse_Click" /></td>
            <td style="width: 339px">
                <asp:Label ID="LabMsg" runat="server" Text="" Forecolor="Green"></asp:Label></td>
        </tr>
    </table>
        </center>
        </div>
</asp:Content>
