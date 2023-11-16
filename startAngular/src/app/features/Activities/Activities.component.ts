import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { CardComponent } from '../../models/card/card.component';

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
        console.log(this.state);
        
    }
}
