<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseView.aspx.cs" Inherits="CoursesApp.Views.CourseView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
        <form id="form1" runat="server">
            <asp:ScriptManager runat="server">
            </asp:ScriptManager>    
            <div>
                <h1>Course Edit</h1>
                <hr />
                <asp:DropDownList ID="ddlCourse" runat="server" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged" DataValueField="Id" DataTextField="Name" AutoPostBack="true">
                </asp:DropDownList>
                <hr />
                <asp:UpdatePanel runat="server" ID="upData">
                    <ContentTemplate>
                        <div>
                            <p>
                            <label>Id:</label>
                            <asp:TextBox ID="tbId" Enabled="false" runat="server"></asp:TextBox>
                            </p>
                        </div>
                        <div>
                            <p>
                            <label>Name:</label>
                            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                            </p>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlCourse" EventName="SelectedIndexChanged"/>
                    </Triggers>
                </asp:UpdatePanel>
                <asp:Button runat="server" Text="New" ID="btNew" OnClick="btNew_Click"></asp:Button>
                <asp:Button runat="server" Text="Save" ID="btSave" OnClick="btSave_Click"></asp:Button>
            </div>
        </form>
    
</body>
</html>
