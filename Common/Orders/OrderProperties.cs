﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

namespace QuantConnect.Orders
{
    /// <summary>
    /// Contains additional properties and settings for an order
    /// </summary>
    public class OrderProperties
    {
        /// <summary>
        /// Optional order properties used by financial advisors.
        /// These properties are currently used only by the Interactive Brokers brokerage.
        /// </summary>
        public OrderFinancialAdvisorProperties FinancialAdvisorProperties { get; set; } = new OrderFinancialAdvisorProperties();

        /// <summary>
        /// Returns a new instance clone of this object
        /// </summary>
        public OrderProperties Clone()
        {
            return new OrderProperties
            {
                FinancialAdvisorProperties = FinancialAdvisorProperties.Clone()
            };
        }
    }
}