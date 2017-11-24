/// <reference path="../jquery.form.js" />

var Employee = function () {

    return {
        init: function () {

        },
        employee201SaveChanges: function() {
            var form = $("#form_employee_201");

            if (form.valid()) {
                form.ajaxSubmit({
                    success: function (result) {
                        HRIS.showAjaxResult(result);
                    }
                });
            }
        },
        employeeBasicInfoSaveChanges: function () {
            var form = $("#form_employee_basic_info");

            if (form.valid()) {
                form.ajaxSubmit({
                    success: function (result) {
                        HRIS.showAjaxResult(result);

                        if (result.success) {
                            if(result.data.extesion == "" || result.data.extesion == null || result.data.extesion == undefined){
                                result.data.extesion= "";
                            }

                            if(result.data.extesion!= ""){
                                $("#empImage", $("#form_employee_basic_info")).attr("src", result.data.path);
                            }
                        }

                    }
                });
            }
        }
    }
}();
