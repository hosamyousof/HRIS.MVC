var HRIS = function () {
    return {
        init: function () {
            kendo.culture("en-GB");
            var culture = kendo.culture();
            //culture.calendar.patterns.d = "dd/MM/yyyy"; // short date pattern
            //culture.calendar.patterns.D = "dd MMM yyyy"; // long date pattern
            //culture.calendar.patterns.t = "HH:mm"; // short time pattern
            //culture.calendar.patterns.T = "HH:mm"; // long time pattern
            //culture.calendar.patterns.g = "dd MMM yyyy HH:mm";
            //culture.calendar.patterns.G = "dd MMM yyyy HH:mm";
            //culture.numberFormat.currency.symbol = "$"; 
            $.ajaxSetup({ cache: false });
            jQuery.validator.addMethod('date', function (value, element, params) { if (this.optional(element)) { return true; }; var result = false; try { var date = kendo.parseDate(value, "MM/dd/yyyy"); result = true; if (!date) { result = false; } } catch (err) { result = false; } return result; }, '');
        },
        centerKendoWindow: function (e) {
            var wrapper = $(e.sender.wrapper);
            var win = $("[data-role='window']", wrapper);
            win.data("kendoWindow").center();
            win.closest(".k-window").css({
                top: 100
            });
        },
        ajaxPost: function (option) {
            var options = $.extend(true, {
                type: "POST", dataType: "json",
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    swal("Error", "Something went wrong... Please contact administrator.", "error");
                }
            }, option);
            return $.ajax(options);
        },
        showAjaxResult: function (option) {
            var title = option.title;
            var result = option.result == undefined ? option : option.result;
            if (option.success != undefined) {
                title = result.success ? "Success" : "Error";
            }
            if (result.modelStateValidation) {
                if (result.success) {
                    if (option.alert == undefined) {
                        swal(title, result.successMsg, "success");
                    }
                    else {
                        option.alert();
                    }
                }
                else {
                    if (result.errors.length != 0) {
                        var errors = "<ul class='errorlist'>";
                        for (var i = 0; i < result.errors.length; i++) {
                            errors = errors + "<li>" + result.errors[i] + "</li>"
                        }
                        errors = errors + "</li>";
                        if (option.alert == undefined) {
                            swal({
                                html: true,
                                title: result.errorMsg,
                                text: errors,
                                type: "error",
                            })
                        }
                        else {
                            option.alert(errors);
                        }
                    }
                }
            }
            else {
                if (result.success) {
                    swal(title, result.msg, "success");
                }
                else {
                    swal(title, result.msg, "error");
                }
            }
        }
    }
}();

$(document).ready(function () {
    HRIS.init();
});

function error_handler(e) {
    if (e.errors) {
        var message = "Errors:\n";
        $.each(e.errors, function (key, value) {
            if ('errors' in value) {
                $.each(value.errors, function () {
                    message += this + "\n";
                });
            }
        });
        swal("Warning", message, "errorx");
    }
}



