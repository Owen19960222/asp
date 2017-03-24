﻿@ModelType ManageUserViewModel

<p class="text-info">
    您沒有此網站的本機使用者名稱/密碼。請新增本機
    帳戶，以在不使用外部登入的情況下登入。
</p>

@Using Html.BeginForm("Manage", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>
        <h4>建立本機登入</h4>
        <hr />
         @Html.ValidationSummary()
         <div class="form-group">
            @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="設定密碼" class="btn btn-default" />
            </div>
        </div>
    </text>
End Using