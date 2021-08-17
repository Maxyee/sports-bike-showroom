import React from 'react'
import { Link } from 'react-router-dom';

export default function Header() {
    return (
        <div>
            <div className="flex justify-center text-4xl bg-gray-400">
                Sports Bike Showroom
            </div>
            <Link to="/addbike">
                <button className="bg-gray-200">AddBike</button>
            </Link> 
        </div>
        
    )
}
