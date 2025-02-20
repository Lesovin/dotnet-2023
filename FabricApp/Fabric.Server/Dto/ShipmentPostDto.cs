﻿namespace Fabrics.Server.Dto;

/// <summary>
/// Class ShipmentGetDto is used to make HTTP POST request.
/// </summary>
public class ShipmentPostDto
{
    /// <summary>
    /// FabricId is used to store the ID of recipient.
    /// </summary>
    public int FabricId { get; set; } = 0;
    /// <summary>
    /// ProviderId is used to store the ID of sender.
    /// </summary>
    public int ProviderId { get; set; } = 0;
    /// <summary>
    /// Date is used to store the information about date of shipment.
    /// </summary>
    public DateTime Date { get; set; }
    /// <summary>
    /// NumberOfGoods is used to store the information about amount of goods in shipment.
    /// </summary>
    public int NumberOfGoods { get; set; }
}
