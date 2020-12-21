import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-currency',
  templateUrl: './currency.component.html'
})
export class CurrencyComponent {
  public currencies: Currency[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Currency[]>(baseUrl + 'currencies').subscribe(result => {
      this.currencies = result as Currency[];
    }, error => console.error(error));
  }

}

class Currency {
  name: string;
  amount: number;
  price: number;

}

