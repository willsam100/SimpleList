namespace SimpleList
open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type Employee = {
    DisplayName: string
}

type EmployeeListPage() =
    inherit ContentPage()

    let employees = [
        { DisplayName="Rob Finnerty"}
        { DisplayName="Bill Wrestler"}
        { DisplayName="Dr. Geri-Beth Hooper"}
        { DisplayName="Dr. Keith Joyce-Purdy"}
        { DisplayName="Sheri Spruce"}
        { DisplayName="Burt Indybrick"} ]

    let _ = base.LoadFromXaml(typeof<EmployeeListPage>)
    let employeeListView = base.FindByName<ListView>("EmployeeView")
    do employeeListView.ItemsSource <- ((employees |> List.toSeq) :> Collections.IEnumerable)
    do employeeListView.ItemTapped.AddHandler(
            new EventHandler<ItemTappedEventArgs>(fun x y -> (x :?> ListView).SelectedItem <- null )) 

type App() = 
    inherit Application(MainPage = EmployeeListPage())

