<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AsapTestApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>ID</label>
            <input type="text" id="txtId" name="memberId" runat="server" />
        </div>
        <div>
            
            <label>id</label>
            <input type="text" id="txtFirstname" runat="server" />

        </div>
        <div>
            <label>first_name</label>
            <input type="text" id="Text1" runat="server" />

        </div>
        <div>
            <label>last_name</label>
            <input type="text" id="txtlastname" runat="server" />

        </div>
        <div>
            <label>dob</label>
            <input type="text" id="txtdob" runat="server" />

        </div>
        <div>
            <label>country</label>
            <input type="text" id="txtcountry" maxlength="2" runat="server" />

        </div>
        <div>
            
           
            <button onclick="showAlert()" type="submit" id="btnSubmit"  value="Submit" runat="server">Submit</button>
            <script type="text/javascript">
				function showAlert() {

                    
					if (document.getElementsByName('memberId').Length =6) {
					
                        alert('ID accepted!');
                      
					}
					else {
					
                        alert('ID format error!');
			
					}
				}
			</script>
        </div>
        </form>
</body>
</html>
