import React from 'react'

export default function Bike() {
    return (
        <div className="bg-gray-100">
            <div className="flex justify-center space-x-4">
                <div><img src="/images/bmw1000rr.jpg" alt="bike photo" /></div>
                <div>
                    <p>Model: S1000RR</p>
                    <p>Year: 2021</p>
                    <p>Price: 19000 GBP</p>
                    <p>Engine Speed: 1000cc</p>
                </div>
            </div>
            <div className="bg-black h-1">
            </div>
        </div>
    )
}
