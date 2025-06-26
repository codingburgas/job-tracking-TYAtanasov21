import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
// import { LoginComponent } from './pages/login/login.component';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'login',
    loadComponent: () => import('./pages/login/login.component').then(m => m.LoginComponent)
  },
  {
    path: 'register',
    loadComponent: () => import('./pages/register/register.component').then(m => m.RegisterComponent)
  },
//   { path: 'login', component: LoginComponent }
];
