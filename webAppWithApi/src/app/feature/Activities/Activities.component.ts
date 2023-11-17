import { CardComponent } from './../../model/card/card.component';
import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-Activities',
    standalone: true,
    imports: [CommonModule, CardComponent],
    templateUrl: './Activities.component.html',
})

export class ActivitiesComponent {

    @Input() activity: any[] = []

    state: boolean = false

    toggle() {
        this.state = this.state ? false : true
    }
}