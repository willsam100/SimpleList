namespace SimpleList

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type Employee = {
    DisplayName:string
}


type EmployeeListPage() =
    inherit ContentPage()

    do base.LoadFromXaml(typeof<EmployeeListPage>) |> ignore
    let employees = [{DisplayName="Sam"};{DisplayName="Sol"}]
    let employeeListView = base.FindByName<ListView>("EmployeeView")
    do employeeListView.ItemsSource <- ((employees |> List.toSeq) :> Collections.IEnumerable)

type App() = 
    inherit Application(MainPage = EmployeeListPage())

