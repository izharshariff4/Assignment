import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddItemComponent } from './Components/add-item/add-item.component'
import { UpdateItemComponent } from './Components/update-item/update-item.component'
import {ViewItemsComponent} from'./Components/view-items/view-items.component'



const routes: Routes = [{path:'', redirectTo: "employees", pathMatch:'full'},
{path:'employees/edit/:id', component: UpdateItemComponent},
{path:'employees/addNew', component: AddItemComponent}];
{path:'employees/viewBill/:id', component: ViewItemsComponent}];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
