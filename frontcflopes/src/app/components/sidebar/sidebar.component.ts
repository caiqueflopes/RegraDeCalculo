import { Component, OnInit } from '@angular/core';

declare const $: any;
declare interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}
export const ROUTES: RouteInfo[] = [
    { path: '/user-profile', title: 'Meus Dados',  icon:'person', class: '' },
    { path: '/dashboard', title: 'Pendências',  icon: 'library_books', class: '' }, 
    { path: '/table-list', title: 'Negociados',  icon:'content_paste', class: '' }, 
    //{ path: '/notifications', title: 'notify',  icon:'content_paste', class: '' }, notificações para usar como msgs de sucesso/error etc
    
    
      
];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  menuItems: any[];

  constructor() { }

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
      if ($(window).width() > 991) {
          return false;
      }
      return true;
  };
}
