import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KeyboardsComponent } from './keyboards/keyboards.component';
import { MouseComponent } from './mouse/mouse.component';

const routes: Routes = [
  { path: 'keyboards', component: KeyboardsComponent },
  { path: 'mice', component: MouseComponent },
  { path: '', redirectTo: 'keyboards', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
