<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="CoursesApp.Views.StudentView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Student List</h1>
            <asp:Repeater id="Repeater1" OnItemDataBound="R1_ItemDataBound" runat="server">
              <HeaderTemplate>
              </HeaderTemplate> 
                <ItemTemplate>
                    Id: <asp:Label id ="IdLabel" Text='<%# DataBinder.Eval(Container.DataItem, "Id") %>' Runat="server"/><br />
                    Name: <asp:Label id="NameLabel" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>' Runat="server"/><br />
                    Course Count: <asp:Label id="CourseCountLabel" Text='<%# DataBinder.Eval(Container.DataItem, "CourseCount") %>' Runat="server"/>
                </ItemTemplate>
              <SeparatorTemplate>
                <hr />
              </SeparatorTemplate>
              <FooterTemplate>
              </FooterTemplate>
             
           </asp:Repeater>
        </div>
    </form>
</body>
</html>
