// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Inventories.Projects;

namespace PropertyManager.Domain.Entities.Models.Inventories.Property;

public class Property : BaseEntity
{
    public string? Name { get; set; }

    public string? ProjectId { get; set; }
    public Project? Project { get; set; }

    // Rental
    public TimeSpan TimeIn { get; set; }
    public TimeSpan TimeOut { get; set; }
    public ICollection<Rental> Availabilities { get; set; } = [];
    
    // General Property Information
    
    /// <summary>
    /// Property Type
    /// <example>
    ///  - Unit
    ///  - Villa
    ///  - Plot
    /// </example>
    /// </summary>
    public string? PropertyType { get; set; } 
    
    /// <summary>
    /// Property Listing Type
    /// - For Sale
    /// - For Rent
    /// </summary>
    public string? ListingType { get; set; }
    
    /// <summary>
    /// Property Status
    /// - Draft
    /// - Available
    /// - Sold
    /// - Rented
    /// - Hold
    /// - Unavailable
    /// - Not for Sale
    /// </summary>
    public string? PropertyStatus { get; set; } = "Draft"; 
    public bool IsListed => PropertyStatus == "Available" && ListingType is not null;

    // Location Details
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? Neighborhood { get; set; }
    public string? Address { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Landmark { get; set; }

    // Ownership and Legal Details
    public string? OwnerName { get; set; }
    public string? OwnershipType { get; set; } // Freehold, Leasehold
    public string? TitleDeedNumber { get; set; }
    public string? LegalApprovals { get; set; }
    public string? TenureInformation { get; set; }

    // Dimensions and Layout
    public double TotalArea { get; set; } // In sq.ft. or sq.m.
    public double PlotArea { get; set; }
    public double BuiltUpArea { get; set; }
    public int NumberOfBedrooms { get; set; }
    public int NumberOfBathrooms { get; set; }
    public int NumberOfFloors { get; set; }
    public double BalconySize { get; set; }
    public double GardenSize { get; set; }
    public int ParkingSpaces { get; set; }
    public int FloorNumber { get; set; }
    public string? FurnishingStatus { get; set; } // Fully Furnished, Semi-Furnished, Unfurnished

    // Financial Information
    public decimal Price { get; set; }
    public decimal PricePerUnitArea { get; set; }
    public decimal MaintenanceFees { get; set; }
    public decimal SecurityDeposit { get; set; }
    public decimal OtherCharges { get; set; }

    // Utilities and Features
    public bool HasElectricity { get; set; }
    public bool HasWater { get; set; }
    public string? AirConditioningType { get; set; }
    public string? HeatingSystem { get; set; }
    public bool InternetConnectivity { get; set; }
    public string? UtilityMeters { get; set; } // Individual or Shared

    // Facilities and Amenities
    public bool SwimmingPool { get; set; }
    public bool Gym { get; set; }
    public bool ChildrenPlayArea { get; set; }
    public bool Security { get; set; }
    public bool Clubhouse { get; set; }
    public bool SmartHomeFeatures { get; set; }
    public bool StorageRoom { get; set; }
    public bool Elevator { get; set; }
    public bool LaundryRoom { get; set; }

    // Exterior and Environmental Details
    public string? View { get; set; } // Park View, Sea View, etc.
    public string? Orientation { get; set; } // North, East, South, West
    public string? Accessibility { get; set; } // Road Access, etc.
    public string? LandUseType { get; set; } // Residential, Commercial, etc.
    public string? SoilQuality { get; set; } // For plots

    // Condition and Maintenance
    public int ConstructionYear { get; set; }
    public string? Condition { get; set; } // New, Renovated, etc.
    public string? RenovationDetails { get; set; }
    public string? OccupancyStatus { get; set; } // Vacant, Occupied
    public DateTime? HandoverDate { get; set; }

    // Marketing and Media
    public string? Description { get; set; }
    public List<string> ImageUrls { get; set; } = [];
    public string? VirtualTourUrl { get; set; }
    public List<string> VideoUrls { get; set; } = [];
    public string? AgentContactInfo { get; set; }

    // Regulatory and Taxation
    public decimal PropertyTax { get; set; }
    public string? ZoningInformation { get; set; }
    public string? PermitsRequired { get; set; }
    public string? TaxId { get; set; }

    // Additional Fields
    public string? DeveloperName { get; set; }
    public string? ProjectName { get; set; }
    public string? ExclusiveFeatures { get; set; }
    public string? TermsOfAgreement { get; set; }
}
