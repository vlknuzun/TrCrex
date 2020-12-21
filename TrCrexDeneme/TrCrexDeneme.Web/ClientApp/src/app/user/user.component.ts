import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { inject } from '@angular/core/testing';
import { getBaseUrl } from '../../main';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html'
})
export class UserComponent {

  public users: Users[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Users[]>(baseUrl + 'users').subscribe(result => {
      this.users = result as Users[];
    }, error => console.error(error));
  }

  

}

class Users {
  name: string;
  surname: string;
  username: string;
}
