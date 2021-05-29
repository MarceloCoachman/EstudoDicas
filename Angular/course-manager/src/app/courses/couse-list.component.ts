import { Component, OnInit } from "@angular/core";
import {Couse} from './course';

@Component({
    selector: 'app-course-list',
    templateURl: './course-list.component.html'
})

export class CourseListComponent implements OnInit{
    courses:Course[] = [];
    ngOnInit(): void{
        this.courses= [
            {
                id:1,
                name: 'Angular: forms',
                imageUrl:'',
                price: 99.90,
                code: 'zz2-324',
                duration:120,
                rating: 5.5
            },
            {
                id:2,
                name: 'Angular: HTML',
                imageUrl:'',
                price: 60.00,
                code: 'XX4-4375',
                duration:60,
                rating: 5.0
            }
        ]
    }

}