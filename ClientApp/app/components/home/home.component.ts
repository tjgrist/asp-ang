import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    values = '';
    info = 'here are the words you type';

    keyPress (value: string) {
        this.values += value;
    }

    onEnter () {
        this.values = '';
    }
}
