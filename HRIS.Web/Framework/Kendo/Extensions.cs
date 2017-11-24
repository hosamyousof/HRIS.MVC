using HRIS.Model;
using Kendo.Mvc.UI;
using Kendo.Mvc.UI.Fluent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Web.Framework.Kendo
{
    public static class Extensions
    {
        public static GridBoundColumnBuilder<TModel> SetDefaultSettings<TModel>(this GridBoundColumnBuilder<TModel> gbc) where TModel : class
        {
            gbc
                .Filterable(ftb =>
                {
                    ftb.Cell(cell =>
                    {
                        cell.Operator("contains");
                        cell.ShowOperators(true);
                    });
                });
            return gbc;
        }

        public static GridBuilder<T> SetDefaultSettings<T>(this GridBuilder<T> gb) where T : class
        {
            gb
                .Filterable(filter =>
                {
                    filter.Mode(GridFilterMode.Menu).Extra(false);
                })
                .Sortable()
                .Pageable(pageable => pageable
                    .Refresh(true)
                    .PageSizes(new[] { "15", "30", "50", "100", "All" })
                    .ButtonCount(5))
                .Selectable()
                .NoRecords(nr => nr.Template("<div style='padding: 5px;'>No Record Found</div>"))
                .DataSource(source =>
                {
                    source
                        .Ajax()
                        .PageSize(15)
                        .Events(events => events.Error("error_handler"))
                        .ServerOperation(true);
                });

            return gb;
        }

        public static DropDownListBuilder SetReferenceSettings(this DropDownListBuilder ddlb)
        {
            ddlb.DataValueField("value").DataTextField("description").OptionLabel("select");
            return ddlb;
        }

        public static DropDownListBuilder SetReferenceSettings(this DropDownListBuilder ddlb, ReferenceList name)
        {
            ddlb.SetReferenceSettings()
                .DataSource(source =>
                {
                    source.Custom().Type("aspnetmvc-ajax")
                        .Transport(transport =>
                        {
                            transport.Read(read =>
                            {
                                read.Action("GetReference", "Reference", new { name = name });
                            });
                        })
                        .Schema(schema =>
                        {
                            schema.Data("Data").Total("Total");
                        });
                });
            return ddlb;
        }

        public static DropDownListBuilder SetValueTextDataSourceCustom(this DropDownListBuilder ddlb, string actionName, string controllerName)
        {
            return SetValueTextDataSourceCustom(ddlb, actionName, controllerName, null);
        }

        public static DropDownListBuilder SetValueTextDataSourceCustom(this DropDownListBuilder ddlb, string actionName, string controllerName, object routeValues)
        {
            return SetValueTextDataSourceCustom(ddlb, actionName, controllerName, routeValues, "");
        }

        public static DropDownListBuilder SetValueTextDataSourceCustom(this DropDownListBuilder ddlb, string actionName, string controllerName, object routeValues, string data)
        {
            ddlb.DataValueField("Value")
                .DataTextField("Text")
                .OptionLabel("select")
                .DataSource(source =>
                {
                    source.Custom().Type("aspnetmvc-ajax")
                        .Transport(transport =>
                        {
                            transport.Read(read =>
                            {
                                var r = read.Action(actionName, controllerName, routeValues);
                                if (!string.IsNullOrEmpty(data))
                                {
                                    r.Data(data);
                                }
                            });
                        })
                        .Schema(schema =>
                        {
                            schema.Data("Data").Total("Total");
                        });
                });
            return ddlb;
        }

        public static DropDownListBuilder SetValueTextSettings(this DropDownListBuilder ddlb)
        {
            ddlb.DataValueField("Value").DataTextField("Text");
            return ddlb;
        }

        public static DropDownListBuilder SetValueTextSettings(this DropDownListBuilder ddlb, IEnumerable data)
        {
            ddlb.DataValueField("Value").DataTextField("Text").BindTo(data);
            return ddlb;
        }

        public static GridBoundColumnBuilder<T> TemplateCheckBox<T>(this GridBoundColumnBuilder<T> builder) where T : class
        {
            string template = @"
                    # if({0}) { #
                        <i class='fa fa-lg fa-check'></i>
                    # } else { #
                        <i class='fa fa-lg fa-times'></i>
                    # } #
                ";

            string fieldName = builder.Column.Member;

            template = template.Replace("{0}", fieldName);

            builder.ClientTemplate(template).HtmlAttributes(new { @class = "center" });

            return builder;
        }

        public static WindowBuilder WindowConfirmationSettings(this WindowBuilder builder)
        {
            builder.Width(500)
                .Draggable(true)
                .Modal(true)
                .Scrollable(false)
                .Visible(false);

            return builder;
        }
    }
}