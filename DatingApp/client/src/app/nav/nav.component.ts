import { Component, OnInit, inject } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable, of } from 'rxjs';
import { User } from '../_models/user';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  private router: Router = inject(Router)
  private toastr: ToastrService = inject(ToastrService)



  constructor(public accountService: AccountService,) {

  }

  ngOnInit(): void {
  }



  login() {
    this.accountService.login(this.model).subscribe({
      next: _ => {
        this.router.navigateByUrl('/members');
      },
      error: error => {
        console.log(error)
      }


    })
  }

  logout() {
    this.accountService.logoout();
    this.router.navigateByUrl('/')

  }
}
